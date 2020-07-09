using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
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
        private readonly TarjetaCreditoRepository _tarjetaCreditoRepository;


        public ClientController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository,
            PrestamosRepository prestamosRepository, TarjetaCreditoRepository tarjetaCreditoRepository)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _mapper = mapper;


            ///repositorios
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;
            _prestamosRepository = prestamosRepository;
            _tarjetaCreditoRepository = tarjetaCreditoRepository;


        }

        //Vistas Gets home y beneficiario.
        public async Task<IActionResult> Index()
        {
            int? id = 7;
            int idusuarioentero = Convert.ToInt32(id);

            if (idusuarioentero != null)
            {
                TraerProductosViewModels tpvm = new TraerProductosViewModels();
                var CuentaList = await _context.Cuenta.Where(x => x.IdUsuario == id).ToListAsync();
                var TarjetasList = await _context.TarjetaCredito.Where(x => x.IdUsuario == id).ToListAsync();
                var PrestamosList = await _context.Prestamos.Where(x => x.IdUsuario == id).ToListAsync();

             
                tpvm.user = await  _usuarioRepository.GetByIdAsync(idusuarioentero);
                tpvm.Cuenta = await _cuentaRepository.GetCuentaUsuario(idusuarioentero);
                tpvm.Credito = await _tarjetaCreditoRepository.GetCreditoUsuario(idusuarioentero);
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
        public IActionResult PagosExpreso()
        {
            return View();
        }

        public IActionResult PagosTarjeta()
        {
            return View();
        }


        public IActionResult PagosPrestamo()
        {
            return View();
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
