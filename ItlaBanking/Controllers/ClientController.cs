using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Action;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class ClientController : Controller
    {
        private readonly ItlaBankingContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;


        //repository
        private readonly UsuarioRepository _usuarioRepository;
        private readonly CuentaRepository _cuentaRepository;
        private readonly PrestamosRepository _prestamosRepository;
        private readonly TarjetaCreditoRepository _tarjetasRepository;
        private readonly BeneficiarioRepository _beneficiarioRepository;
        private readonly TransaccionesRepository _transaccionesRepository;




        public ClientController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository,
            TarjetaCreditoRepository tarjetasRepository, PrestamosRepository prestamosRepository, BeneficiarioRepository beneficiarioRepository,
            TransaccionesRepository transaccionesRepository
            )
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _mapper = mapper;


            ///repositorios
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;
            _prestamosRepository = prestamosRepository;
            _tarjetasRepository = tarjetasRepository;
            _beneficiarioRepository = beneficiarioRepository;
            _transaccionesRepository = transaccionesRepository;



        }
      public async Task<int> IdUsuarioClienteAsync() {
            Usuario usu = new Usuario();
            usu = await _usuarioRepository.GetUsuarioByName(User.Identity.Name);
            return usu.IdUsuario;
        }

        [HttpGet]
        //Vistas Gets home y beneficiario.
        public async Task<IActionResult> Index()
        {
            ViewData["Nombre"] = User.Identity.Name;
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {
                int idusuarioentero = Convert.ToInt32(id);
                TraerProductosViewModels tpvm = new TraerProductosViewModels();               
                tpvm.user = await _usuarioRepository.GetByIdAsync(idusuarioentero);
                tpvm.Cuenta = await _cuentaRepository.GetCuentaUsuario(idusuarioentero);
                tpvm.Credito = await _tarjetasRepository.GetCreditoUsuario(idusuarioentero);
                tpvm.Prestamos = await _prestamosRepository.GetPrestamoUsuario(idusuarioentero);
                tpvm.IdUsuario = idusuarioentero;
                return View(tpvm);
            }
            return RedirectToAction("Index", "Login");
        }




        //Pagos 
        [HttpGet]
        public async Task<IActionResult> PagosExpreso()
        {
            ViewData["Nombre"] = User.Identity.Name;
            int? id = await IdUsuarioClienteAsync();

            if (id != null)
            {

                var cuentaUsuario = await _cuentaRepository.GetCuentaUsuario(id.Value);
                PagosViewModel cuentas = new PagosViewModel();
                cuentas.cuenta = cuentaUsuario;
                return View(cuentas);
            }
            
            return View("Index", "Login");
        }


        [HttpPost]
        public async Task<IActionResult> PagosExpreso(PagosViewModel pevm)
        {
            var cuentaUsuario = await _cuentaRepository.GetCuentaUsuario(await IdUsuarioClienteAsync());
            PagosViewModel cuentas = new PagosViewModel();
            cuentas.cuenta = cuentaUsuario;
            ViewData["Nombre"] = User.Identity.Name;
            if (ModelState.IsValid)
            {
                
                var CuentaDestinatario = await _cuentaRepository.GetByIdAsync(pevm.NumeroCuentaPagar.Value);

                if (CuentaDestinatario != null)
                {
                    var CuentaAhorroSeleccionada = await _cuentaRepository.GetByIdAsync(pevm.NumeroCuenta.Value);

                    if (CuentaAhorroSeleccionada.Balance < pevm.Monto)
                    {
                        ModelState.AddModelError("", "Tu cuenta de Ahorro, no tiene suficiente balance para transferir "+pevm.Monto+"");
                        return View(cuentas);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Tu cuenta si tiene dinero");
                        var UsuarioDestinatario = await _usuarioRepository.GetByIdAsync(CuentaDestinatario.IdUsuario);
                        TransaccionesViewModels Transacciones = new TransaccionesViewModels();
                        Transacciones.NumeroCuenta = CuentaAhorroSeleccionada.NumeroCuenta;
                        Transacciones.NumeroCuentaDestinatario = pevm.NumeroCuentaPagar;
                        Transacciones.Monto = pevm.Monto;
                        Transacciones.Nombre = UsuarioDestinatario.Nombre;
                        Transacciones.Apellido = UsuarioDestinatario.Apellido;
                        Transacciones.TipoTransaccion = 1;
                                                                       
                        return RedirectToAction("ConfirmPagosExpreso", "Client",Transacciones);
                    }
                    
                }
                else
                {
                    ModelState.AddModelError("", "La cuenta que digito no existe, por favor intente con otra");
                    return View(cuentas);
                }
            }
            return View(cuentas);

        }

        
        public IActionResult ConfirmPagosExpreso(TransaccionesViewModels Transacciones)
        {
            return View(Transacciones);
        }
         
        [HttpPost]
        public async Task<IActionResult> TransferenciaPagoExpreso(TransaccionesViewModels Tr)
        {

            if (Tr != null) {


                var cuentaPrincipalUsuario = await _cuentaRepository.GetByIdAsync(Tr.NumeroCuenta);
                var cuentaDestinatario = await _cuentaRepository.GetByIdAsync(Tr.NumeroCuentaDestinatario.Value);

                decimal resta = Convert.ToDecimal(cuentaPrincipalUsuario.Balance - Tr.Monto);
                decimal suma = Convert.ToDecimal(cuentaDestinatario.Balance + Tr.Monto);

                cuentaPrincipalUsuario.Balance = resta;
                cuentaDestinatario.Balance = suma;

                await _cuentaRepository.Update(cuentaPrincipalUsuario);
                await _cuentaRepository.Update(cuentaDestinatario);

                var transacciones = _mapper.Map<Transacciones>(Tr);
                await _transaccionesRepository.AddAsync(transacciones);

                return RedirectToAction("Index");
             }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> PagosTarjeta()
        {
            ViewData["Nombre"] = User.Identity.Name;
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {

                CuentasyPagos cp = new CuentasyPagos(_context, _userManager, _cuentaRepository,
                    _tarjetasRepository, _prestamosRepository);
                return View(cp.TraerCuentas(id));
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PagosTarjeta(PagosViewModel ptvm)
        {
            ViewData["Nombre"] = User.Identity.Name;
            CuentasyPagos cp = new CuentasyPagos(_context, _userManager, _cuentaRepository,
                    _tarjetasRepository, _prestamosRepository);

            if (ModelState.IsValid)
            {
                PagosViewModel pvm = new PagosViewModel();
                
                pvm = await cp.PagoTarjeta(ptvm);
                if (pvm == null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(cp.TraerCuentas(await IdUsuarioClienteAsync()));
                }


            }
            return View(cp.TraerCuentas(await IdUsuarioClienteAsync()));
        }


        public async Task<IActionResult> PagosPrestamo()
        {
            ViewData["Nombre"] = User.Identity.Name;
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {

                CuentasyPagos cp = new CuentasyPagos(_context, _userManager, _cuentaRepository,
                    _tarjetasRepository, _prestamosRepository);
                
                return View(cp.TraerCuentas(id));
            }

            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public async Task<IActionResult> PagosPrestamo(PagosViewModel ppvm)
        {
            ViewData["Nombre"] = User.Identity.Name;
            CuentasyPagos cp = new CuentasyPagos(_context, _userManager, _cuentaRepository,
                    _tarjetasRepository, _prestamosRepository);
            if (ModelState.IsValid) {
                PagosViewModel pvm = new PagosViewModel();
                
                pvm = await cp.PagoPrestamo(ppvm);
                if (pvm == null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(cp.TraerCuentas(await IdUsuarioClienteAsync()));
                }



            }
            return View(cp.TraerCuentas(await IdUsuarioClienteAsync()));
        }

        public async Task<IActionResult> Beneficiario()
        {
            ViewData["Nombre"] = User.Identity.Name;

            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);

            var newBeneficiarios = await _context.probandoBeneficiarioViewModels.FromSql("TodosBeneficiarios @IdUsuario = {0}", usu.IdUsuario).ToListAsync();

            BeneficiarioViewModel bf = new BeneficiarioViewModel();
            bf.LosBeneficiarios = newBeneficiarios;

            return View(bf);
        }

        public IActionResult AddBeneficiario() {
            return View();

         }

        [HttpPost]
        public async Task<IActionResult> AddBeneficiario(ProbandoBeneficiarioViewModel pbv)
        {
            var cuental = await _cuentaRepository.GetByIdAsync(pbv.CuentaBeneficiario);

            if (cuental != null)
            {
                Usuario usu = new Usuario();
                usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);

                pbv.IdUsuarioBeneficiario = cuental.IdUsuario;
                pbv.IdUsuarioCliente = usu.IdUsuario;


                var norepetidos = _beneficiarioRepository.GetBeneficiarios(pbv.IdUsuarioBeneficiario, pbv.CuentaBeneficiario );

                if (norepetidos != null)
                {
                    ModelState.AddModelError("", "El numero de cuenta " + pbv.CuentaBeneficiario + " ya lo tienes como beneficiario");
                    return View(pbv);
                }

                var Beneficiario = _mapper.Map<Beneficiario>(pbv);
                


                await _beneficiarioRepository.AddAsync(Beneficiario);
                return RedirectToAction("Beneficiario");
            }

            ModelState.AddModelError("", "El numero de cuenta "+pbv.CuentaBeneficiario+" no existe.");
            return View(pbv);
       
    
        }

        [HttpPost]
        public async Task<IActionResult> EliminarBeneficiario(int IdUsuarioClient, int IdUsuarioBeneficiario, int CuentaBeneficiario)
        {

            Beneficiario bn = new Beneficiario()
            {
                    IdUsuarioCliente = IdUsuarioClient,
                    IdUsuarioBeneficiario = IdUsuarioBeneficiario,
                    CuentaBeneficiario = CuentaBeneficiario
            };

            var validandob = _beneficiarioRepository.ValidandoBeneficiarios(bn.IdUsuarioCliente, bn.IdUsuarioBeneficiario, bn.CuentaBeneficiario);

            if(validandob != null){
                await _beneficiarioRepository.DeleteEntity(validandob);
                return RedirectToAction("Beneficiario");
            }

            return RedirectToAction("Error");
        }




        public async Task<IActionResult> PagosBeneficiario()
        {


            CuentasyPagos cp = new CuentasyPagos(_context, _userManager, _cuentaRepository,
                _tarjetasRepository, _prestamosRepository);



            return View(await cp.Beneficiarios(User.Identity.Name));
        }

        [HttpPost]
        public async Task<IActionResult> PagosBeneficiario(BeneficiarioViewModel bvm)
        {
         ViewData["Nombre"] = User.Identity.Name;
            CuentasyPagos cp = new CuentasyPagos(_context, _userManager, _cuentaRepository,
                _tarjetasRepository, _prestamosRepository);
            if (ModelState.IsValid) {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == bvm.NumeroCuenta);
                var cuenta2 = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == bvm.NumeroCuentaPagar);
                if (cuenta  == null || cuenta2 == null) {
                    ModelState.AddModelError("", "Cuenta o cuentas inexistentes");

                    return View(await cp.Beneficiarios(User.Identity.Name));
                }
                if (cuenta.Balance< bvm.Monto) {
                    ModelState.AddModelError("", "No tiene suficiente balance");
                    return View(await cp.Beneficiarios(User.Identity.Name));
                }
                cuenta.Balance = cuenta.Balance - bvm.Monto;
                cuenta2.Balance = cuenta2.Balance + bvm.Monto;
                try
                {
                    //await _cuentaRepository.Update(cuenta);
                    //await _cuentaRepository.Update(cuenta2);
                    ModelState.AddModelError("", "Tu cuenta si tiene dinero");
                    var UsuarioDestinatario = await _usuarioRepository.GetByIdAsync(cuenta2.IdUsuario);
                    TransaccionesViewModels Transacciones = new TransaccionesViewModels();
                    Transacciones.NumeroCuenta = cuenta.NumeroCuenta;
                    Transacciones.NumeroCuentaDestinatario = bvm.NumeroCuentaPagar;
                    Transacciones.Monto = bvm.Monto;
                    Transacciones.Nombre = UsuarioDestinatario.Nombre;
                    Transacciones.Apellido = UsuarioDestinatario.Apellido;
                    Transacciones.TipoTransaccion = 1;

                    return RedirectToAction("ConfirmPagosBeneficiario", "Client", Transacciones);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(bvm);
}


        public IActionResult ConfirmPagosBeneficiario(TransaccionesViewModels transacciones)
        {

            return View(transacciones);
        }
        [HttpPost]
        public async Task<IActionResult> TransferenciaPagoBeneficiario(TransaccionesViewModels Tr)
        {

            if (Tr != null)
            {
                var cuentaPrincipalUsuario = await _cuentaRepository.GetByIdAsync(Tr.NumeroCuenta);
                var cuentaDestinatario = await _cuentaRepository.GetByIdAsync(Tr.NumeroCuentaDestinatario.Value);

                decimal resta = Convert.ToDecimal(cuentaPrincipalUsuario.Balance - Tr.Monto);
                decimal suma = Convert.ToDecimal(cuentaDestinatario.Balance + Tr.Monto);

                cuentaPrincipalUsuario.Balance = resta;
                cuentaDestinatario.Balance = suma;

                await _cuentaRepository.Update(cuentaPrincipalUsuario);
                await _cuentaRepository.Update(cuentaDestinatario);

                var transacciones = _mapper.Map<Transacciones>(Tr);
                await _transaccionesRepository.AddAsync(transacciones);

                return RedirectToAction("Index");
            }

            return RedirectToAction("Error");
        }


        public async Task<IActionResult> AgregarBeneficiario(BeneficiarioViewModel agg)
        {
            if (agg.NumeroCuenta == null)
            {
                return RedirectToAction("Beneficiario");

            }
            else {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == agg.NumeroCuenta);
                if (cuenta!= null) {
                    Beneficiario bn = new Beneficiario();
                    bn.IdUsuarioCliente = agg.IdUsuario;
                    bn.IdUsuarioBeneficiario = cuenta.IdUsuario;
                    await _context.Beneficiario.AddAsync(bn);
                    await _context.SaveChangesAsync();
                }
                


            }
            return RedirectToAction("Beneficiario");
        }

   
       
        //OtrasVista
        public async Task<IActionResult> AvanceEfectivo()
        {
            
            ViewData["Nombre"] = User.Identity.Name;
       
            var cuentaUsuario = await _cuentaRepository.GetCuentaUsuario(await IdUsuarioClienteAsync());
            var TarjetaUsuario = await _tarjetasRepository.GetCreditoUsuario(await IdUsuarioClienteAsync());

            AvanceEfectivoViewModel avanceCuenta = new AvanceEfectivoViewModel();
            avanceCuenta.cuenta = cuentaUsuario;
            avanceCuenta.tarjetas = TarjetaUsuario;


            return View(avanceCuenta);
        }

        [HttpPost]
        public async Task<IActionResult> AvanceEfectivo(AvanceEfectivoViewModel Aev)
        {

            var cuentaUsuario = await _cuentaRepository.GetCuentaUsuario(await IdUsuarioClienteAsync());
            var TarjetaUsuario = await _tarjetasRepository.GetCreditoUsuario(await IdUsuarioClienteAsync());
            ViewBag.exists = "";
            Aev.cuenta = cuentaUsuario;
            Aev.tarjetas = TarjetaUsuario;

            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid)
            {

                var CuentaTarjetaCredito = await _tarjetasRepository.GetByIdAsync(Aev.NumeroTarjeta.Value);
                var CuentaAhorroSeleccionada = await _cuentaRepository.GetByIdAsync(Aev.NumeroCuenta.Value);

                double deuda = Convert.ToDouble(CuentaTarjetaCredito.Deuda);
                double MontoOne = Convert.ToDouble(Aev.Monto);
                double MontoVerdadero = MontoOne * 0.0625;
                double deuda1 = Convert.ToDouble(CuentaTarjetaCredito.Deuda);
                double MontoDeudaTotal = MontoOne + MontoVerdadero +deuda1;
                decimal result = Convert.ToDecimal(MontoDeudaTotal);


                if (result > CuentaTarjetaCredito.MontoLimite)
                {

                    ModelState.AddModelError("", "El monto del avance de efectivo supera el monto limite de la tarjeta de crédito numero " + CuentaTarjetaCredito.NumeroTarjeta);
                    return View(Aev);
                }
                else
                {
                  
                    CuentaAhorroSeleccionada.Balance = CuentaAhorroSeleccionada.Balance + Aev.Monto;
                    await _cuentaRepository.Update(CuentaAhorroSeleccionada);

                    CuentaTarjetaCredito.Deuda = result;
                    await _tarjetasRepository.Update(CuentaTarjetaCredito);


                    var transacciones = _mapper.Map<Transacciones>(Aev);
                    transacciones.NumeroCuentaDestinatario = CuentaTarjetaCredito.NumeroTarjeta;
                    await _transaccionesRepository.AddAsync(transacciones);
                    ViewBag.exists = "Avance de efectivo, realizado sastifactoriamente.";

                    return View(Aev);
                }


            }

            return View(Aev);
        }


            public async Task<IActionResult> Transferencia()
            {
            ViewData["Nombre"] = User.Identity.Name;

            var cuentaUsuario = await _cuentaRepository.GetCuentaUsuario(await IdUsuarioClienteAsync());

            AvanceEfectivoViewModel avanceCuenta = new AvanceEfectivoViewModel();
            avanceCuenta.cuenta = cuentaUsuario;
            avanceCuenta.cuentaMismoCliente = cuentaUsuario;


            return View(avanceCuenta);
        }

        [HttpPost]
        public async Task<IActionResult> Transferencia(AvanceEfectivoViewModel tf)
        {

            var cuentaUsuario = await _cuentaRepository.GetCuentaUsuario(await IdUsuarioClienteAsync());
            tf.cuenta = cuentaUsuario;
            tf.cuentaMismoCliente = cuentaUsuario;

            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid)
            {

                if (tf.NumeroCuenta == tf.NumeroCuentaDestinatario)
                { 

                    ModelState.AddModelError("","La cuenta destinataria es igual a la cuenta de origen, transferencia invalida");
                    return View(tf);
                }

             


            }


                return View(tf);
        }



    }
}
