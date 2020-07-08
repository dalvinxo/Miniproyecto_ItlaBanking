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

namespace ItlaBanking.Controllers
{
    public class AdministradorController : Controller
    {
        //conection db
        private readonly ItlaBankingContext _context;

        //repository
        private readonly UsuarioRepository _usuarioRepository;

        //identity
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;


        public AdministradorController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, UsuarioRepository usuarioRepository)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _usuarioRepository = usuarioRepository;


        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> AdministrarUsuario()
        {
            //var ListaUsuarios = await _usuarioRepository.GetAllAsync();

            var ListaUsuarios = await _usuarioRepository.GetUsuarioOrder();
            //var ListaUsuarios = await _usuarioRepository.GetUsuarioSpecific();
            
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