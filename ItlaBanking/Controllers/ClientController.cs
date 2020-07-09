using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
    [Authorize(Roles ="Cliente")]
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


        public ClientController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository,
            TarjetaCreditoRepository tarjetasRepository, PrestamosRepository prestamosRepository)

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

             
                tpvm.user = await  _usuarioRepository.GetByIdAsync(idusuarioentero);
                tpvm.Cuenta = await _cuentaRepository.GetCuentaUsuario(idusuarioentero);
                tpvm.Credito = await _tarjetasRepository.GetCreditoUsuario(idusuarioentero);
                tpvm.Prestamos = await _prestamosRepository.GetPrestamoUsuario(idusuarioentero);
                tpvm.IdUsuario = idusuarioentero;


                return View(tpvm);

            }

            return RedirectToAction("Index", "Login");
        }

        public IActionResult Beneficiario()
        {
            return View();
        }


        //Pagos 
        public async Task<IActionResult> PagosExpreso()
        {
            
            return View();
        }

        public async Task<IActionResult> PagosTarjeta()
        {
            ViewData["Nombre"] = User.Identity.Name;
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {
                PagosViewModel ptvm = new PagosViewModel();
                var CuentaList = await _context.Cuenta.Where(x => x.IdUsuario == id).ToListAsync();
                var TarjetasList = await _context.TarjetaCredito.Where(x => x.IdUsuario == id).ToListAsync();
                ptvm.cuenta = CuentaList;
                ptvm.tarjetas = TarjetasList;



                return View(ptvm);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PagosTarjeta(PagosViewModel ptvm)

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
            Usuario usu = new Usuario();
            usu = await _context.Usuario.FirstOrDefaultAsync(x => x.Usuario1 == User.Identity.Name);
            int? id = usu.IdUsuario;
            if (id != null)
            {
                PagosViewModel ppvm = new PagosViewModel();
                var CuentaList = await _context.Cuenta.Where(x => x.IdUsuario == id).ToListAsync();
                var PrestamosList = await _context.Prestamos.Where(x => x.IdUsuario == id).ToListAsync();
                ppvm.cuenta = CuentaList;
                ppvm.prestamos = PrestamosList;

                //ppvm.IdUsuario = Convert.ToInt32(id);


                return View(ppvm);

            }

            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public async Task<IActionResult> PagosPrestamo(PagosViewModel ppvm)
        {
            ViewData["Nombre"] = User.Identity.Name;

            if (ModelState.IsValid) {
                

                var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x=>x.NumeroCuenta == ppvm.NumeroCuenta);
                var prestamo = await _context.Prestamos.FirstOrDefaultAsync(x => x.NumeroPrestamo == ppvm.NumeroCuentaPagar);
                if (cuenta  == null || prestamo == null) {
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
                    ppvm.Monto = ppvm.Monto- prestamo.Monto;
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

        public IActionResult PagosBeneficiario()
        {
            return View();
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
