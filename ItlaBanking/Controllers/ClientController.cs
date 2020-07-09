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

        public ClientController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _mapper = mapper;


            ///repositorios
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;


        }

        [HttpGet]
        //Vistas Gets home y beneficiario.
        public async Task<IActionResult> Index()
        {
            int? id = 9;
            if (id != null)
            {
                TraerProductosViewModels tpvm = new TraerProductosViewModels();
                var CuentaList = await _context.Cuenta.Where(x => x.IdUsuario == id).ToListAsync();
                var TarjetasList = await _context.TarjetaCredito.Where(x => x.IdUsuario == id).ToListAsync();
                var PrestamosList = await _context.Prestamos.Where(x => x.IdUsuario == id).ToListAsync();
                tpvm.user = await _context.Usuario.FirstOrDefaultAsync(x=>x.IdUsuario == id);
                tpvm.Cuenta = CuentaList;
                tpvm.Credito = TarjetasList;
                tpvm.Prestamos = PrestamosList;

                tpvm.IdUsuario = Convert.ToInt32(id);


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
