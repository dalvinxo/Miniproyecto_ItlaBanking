using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using ItlaBanking.Repository;
using Microsoft.AspNetCore.Authorization;

namespace ItlaBanking.Controllers

{
    [Authorize(Roles ="Administrador")]
    public class AdministradorController : Controller
    {
        //conection db

        //repository
        private readonly UsuarioRepository _usuarioRepository;
        private readonly CuentaRepository _cuentaRepository;
        private readonly PrestamosRepository _prestamosRepository;
        private readonly TarjetaCreditoRepository _tarjetaCreditoRepository;
        private readonly ItlaBankingContext _context;
        

        //identity
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;


        public AdministradorController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
           UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository, PrestamosRepository prestamosRepository,
            TarjetaCreditoRepository tarjetaCreditoRepository, ItlaBankingContext context
          )
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;
            _tarjetaCreditoRepository = tarjetaCreditoRepository;
            _prestamosRepository = prestamosRepository;
            _context = context;


        }
        public async Task<IActionResult> Index()
        {
            ViewData["Nombre"] =User.Identity.Name;

            var Estadisticas = await _context.estadisticaAdministradorViewModel.FromSql("Estadisticas").ToListAsync();
                        
            EstadisticaAdministradorViewModel estadistica = new EstadisticaAdministradorViewModel();

            
            estadistica.stats = Estadisticas;
            return View(estadistica);
        }


        public async Task<IActionResult> AdministrarUsuario()
        {
            ViewData["Nombre"] = User.Identity.Name;

            var ListaUsuarios = await _usuarioRepository.GetUsuarioOrder();
            
            return View(ListaUsuarios);

        }

        public async Task<IActionResult> Activador(int? id)
        {

              try
            {

                var Usuario = await _usuarioRepository.GetByIdAsync(id.Value);

                if (Usuario == null)
                {
                    return RedirectToAction("Error", "Home");
                }
                
                    if (Usuario.Estado == "Activo") {
                    Usuario.Estado = "Inactivo";
                }
                else {
                    Usuario.Estado = "Activo";
                    var user = await _userManager.FindByNameAsync(Usuario.Usuario1);

                    await _userManager.ResetAccessFailedCountAsync(user);

                }

                await _usuarioRepository.Update(Usuario);

            }
            catch
            {

                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction("AdministrarUsuario","Administrador");

        }

     
    }
}