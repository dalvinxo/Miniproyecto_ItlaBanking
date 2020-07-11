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
<<<<<<< HEAD
        private readonly BeneficiarioRepository _beneficiarioRepository;
=======
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e


        public ClientController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository,
<<<<<<< HEAD
            TarjetaCreditoRepository tarjetasRepository, PrestamosRepository prestamosRepository, BeneficiarioRepository beneficiarioRepository)
=======
            TarjetaCreditoRepository tarjetasRepository, PrestamosRepository prestamosRepository)
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e

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
<<<<<<< HEAD
            _beneficiarioRepository = beneficiarioRepository;
=======

>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e


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
                var CuentaList = await _context.Cuenta.Where(x => x.IdUsuario == id).ToListAsync();
                var TarjetasList = await _context.TarjetaCredito.Where(x => x.IdUsuario == id).ToListAsync();
                var PrestamosList = await _context.Prestamos.Where(x => x.IdUsuario == id).ToListAsync();


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
        public async Task<IActionResult> PagosExpreso()
        {
            ViewData["Nombre"] = User.Identity.Name;
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {
                CuentasyPagos cp = new CuentasyPagos(_context, _userManager);
                return View(cp.TraerCuentas(id));
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> PagosExpreso(PagosViewModel ptvm)

        {
            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid)
            {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuenta);
                var cuenta2 = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuentaPagar);
                if (cuenta == null || cuenta2 == null)
                {
                    ModelState.AddModelError("", "Cuenta Inexistente");

                    return RedirectToAction("Transferencia");
                }
                if (cuenta.Balance < ptvm.Monto)
                {
                    ModelState.AddModelError("", "No tiene suficiente balance");
                    return View(ptvm);

                }
                cuenta.Balance = cuenta.Balance - ptvm.Monto;


                cuenta2.Balance = cuenta2.Balance + ptvm.Monto;


                try
                {
                    await _cuentaRepository.Update(cuenta);
                    await _cuentaRepository.Update(cuenta2);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(ptvm);
<<<<<<< HEAD
        }

        public IActionResult ConfirmPagosExpreso() {

            return View();
        }

        public IActionResult ConfirmPagosBeneficiario() {

            return View();
        }
=======
        }


>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e



        public async Task<IActionResult> PagosTarjeta()
        {
            ViewData["Nombre"] = User.Identity.Name;
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {
                CuentasyPagos cp = new CuentasyPagos(_context, _userManager);
                return View(cp.TraerCuentas(id));
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PagosTarjeta(PagosViewModel ptvm)
<<<<<<< HEAD
        {
            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid)
            {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuenta);
                var tarjeta = await _context.TarjetaCredito.FirstOrDefaultAsync(x => x.NumeroTarjeta == ptvm.NumeroCuentaPagar);
                if (cuenta == null || tarjeta == null)
                {
                    return RedirectToAction("Transferencia");
                }
                if (cuenta.Balance < ptvm.Monto)
                {
                    ModelState.AddModelError("", "No tiene suficiente balance");
                    return View();

                }
                cuenta.Balance = cuenta.Balance - ptvm.Monto;

                if (tarjeta.MontoLimite > ptvm.Monto)
                {
                    tarjeta.MontoLimite = tarjeta.MontoLimite - ptvm.Monto;
                }
                else if (tarjeta.MontoLimite < ptvm.Monto)
                {
                    ptvm.Monto = ptvm.Monto - tarjeta.MontoLimite;
                    tarjeta.MontoLimite = 0;
                    cuenta.Balance = cuenta.Balance + ptvm.Monto;

                }
                try
                {
                    await _cuentaRepository.Update(cuenta);
                    await _tarjetasRepository.Update(tarjeta);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(ptvm);
        }



        public async Task<IActionResult> PagosPrestamo()
        {
            ViewData["Nombre"] = User.Identity.Name;
=======

        {
            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid)
            {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuenta);
                var tarjeta = await _context.TarjetaCredito.FirstOrDefaultAsync(x => x.NumeroTarjeta == ptvm.NumeroCuentaPagar);
                if (cuenta == null || tarjeta == null)
                {
                    return RedirectToAction("Transferencia");
                }
                if (cuenta.Balance < ptvm.Monto)
                {
                    ModelState.AddModelError("", "No tiene suficiente balance");
                    return View();

                }
                cuenta.Balance = cuenta.Balance - ptvm.Monto;

                if (tarjeta.MontoLimite > ptvm.Monto)
                {
                    tarjeta.MontoLimite = tarjeta.MontoLimite - ptvm.Monto;
                }
                else if (tarjeta.MontoLimite < ptvm.Monto)
                {
                    ptvm.Monto = ptvm.Monto - tarjeta.MontoLimite;
                    tarjeta.MontoLimite = 0;
                    cuenta.Balance = cuenta.Balance + ptvm.Monto;

                }
                try
                {
                    await _cuentaRepository.Update(cuenta);
                    await _tarjetasRepository.Update(tarjeta);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(ptvm);
        }



        public async Task<IActionResult> PagosPrestamo()
        {
            ViewData["Nombre"] = User.Identity.Name;
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {
                CuentasyPagos cp = new CuentasyPagos(_context, _userManager);
                return View(cp.TraerCuentas(id));
            }

            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public async Task<IActionResult> PagosPrestamo(PagosViewModel ppvm)
        {
            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid) {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ppvm.NumeroCuenta);
                var prestamo = await _context.Prestamos.FirstOrDefaultAsync(x => x.NumeroPrestamo == ppvm.NumeroCuentaPagar);
                if (cuenta == null || prestamo == null) {
                    return RedirectToAction("Transferencia");

                }
                if (cuenta.Balance < ppvm.Monto) {
                    ModelState.AddModelError("", "No tiene suficiente balance");

                    return View();

                }
                cuenta.Balance = cuenta.Balance - ppvm.Monto;

                if (prestamo.Monto > ppvm.Monto) {
                    prestamo.Monto = prestamo.Monto - ppvm.Monto;
                } else if (prestamo.Monto < ppvm.Monto) {
                    ppvm.Monto = ppvm.Monto - prestamo.Monto;
                    prestamo.Monto = 0;
                    cuenta.Balance = cuenta.Balance + ppvm.Monto;

                }
                try
                {
                    await _cuentaRepository.Update(cuenta);
                    await _prestamosRepository.Update(prestamo);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(ppvm);
        }
<<<<<<< HEAD
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
=======
        public IActionResult Beneficiario()
        {

            CuentasyPagos cp = new CuentasyPagos(_context, _userManager);

            return View(cp.Beneficiarios(User.Identity.Name));
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e
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




        public IActionResult PagosBeneficiario()
        {

            CuentasyPagos cp = new CuentasyPagos(_context, _userManager);

            return View(cp.Beneficiarios(User.Identity.Name));
<<<<<<< HEAD
=======
        }

        [HttpPost]
        public async Task<IActionResult> PagosBeneficiario(BeneficiarioViewModel bvm)
        {
         ViewData["Nombre"] = User.Identity.Name;
            if (ModelState.IsValid) {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == bvm.NumeroCuenta);
                var cuenta2 = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == bvm.NumeroCuentaPagar);
                if (cuenta  == null || cuenta2 == null) {
                    return RedirectToAction("Transferencia");
                }
                if (cuenta.Balance< bvm.Monto) {
                    ModelState.AddModelError("", "No tiene suficiente balance");
                    return RedirectToAction("Transferencia");
                }
                cuenta.Balance = cuenta.Balance - bvm.Monto;
                cuenta2.Balance = cuenta2.Balance + bvm.Monto;
                try
                {
                    await _cuentaRepository.Update(cuenta);
                    await _cuentaRepository.Update(cuenta2);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(bvm);
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
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e
        }

        [HttpPost]
        public async Task<IActionResult> PagosBeneficiario(BeneficiarioViewModel bvm)
        {
         ViewData["Nombre"] = User.Identity.Name;
            if (ModelState.IsValid) {
                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == bvm.NumeroCuenta);
                var cuenta2 = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == bvm.NumeroCuentaPagar);
                if (cuenta  == null || cuenta2 == null) {
                    return RedirectToAction("Transferencia");
                }
                if (cuenta.Balance< bvm.Monto) {
                    ModelState.AddModelError("", "No tiene suficiente balance");
                    return RedirectToAction("Transferencia");
                }
                cuenta.Balance = cuenta.Balance - bvm.Monto;
                cuenta2.Balance = cuenta2.Balance + bvm.Monto;
                try
                {
                    await _cuentaRepository.Update(cuenta);
                    await _cuentaRepository.Update(cuenta2);
                }
                catch { }

                return RedirectToAction("Index");


            }
            return View(bvm);
}

       
        //OtrasVista
        public IActionResult AvanceEfectivo()
        {
            return View();
        }
        
        public IActionResult Transferencia()
        {
            return View();
        }
        


    }
}
