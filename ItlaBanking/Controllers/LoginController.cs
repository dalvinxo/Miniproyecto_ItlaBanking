using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
    public class LoginController : Controller
    {

        private readonly ItlaBankingContext _context;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;
        private readonly UsuarioRepository _usuarioRepository;


        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ItlaBankingContext context,
                                UsuarioRepository usuarioRepository)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _usuarioRepository = usuarioRepository;



        }
        public async Task<int> IdUsuarioClienteAsync(string user)
        {
            Usuario usu = new Usuario();
            usu = await _usuarioRepository.GetUsuarioByName(user);
            return usu.IdUsuario;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated) {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                if (await _userManager.IsInRoleAsync(user, "Administrador")) {
                    return RedirectToAction("Index", "Administrador");

                }
                else if(await _userManager.IsInRoleAsync(user, "Cliente"))
                {
                    return RedirectToAction("Index", "Client");

                }
                

            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel lvm)
        {
            var user = await _userManager.FindByNameAsync(lvm.Usuario1);
            if (user == null) {
                ModelState.AddModelError("", "Usuario o clave incorrectos");
                return View(lvm);
            }
            var Usuario = await _usuarioRepository.GetByIdAsync(await IdUsuarioClienteAsync(user.UserName));
            if (Usuario.Estado == "Inactivo")
            {
                return RedirectToAction("UsuarioDes", "Login");

            }
            if (Usuario.TipoUsuario == "Cliente") {
                if (await _userManager.GetAccessFailedCountAsync(user) > 3)
                {

                    return RedirectToAction("Desactivador", "Login",new { @id = Usuario.IdUsuario });

                }
            }
            
            if (ModelState.IsValid) {
                var result = await _signinManager.PasswordSignInAsync(lvm.Usuario1, lvm.Clave, false,true);
                if (result.Succeeded)
                {
                    await _userManager.ResetAccessFailedCountAsync(user);


                    if (await _userManager.IsInRoleAsync(user, "Cliente")) {
                        return RedirectToAction("Index", "Client");
                    }
                    else if(await _userManager.IsInRoleAsync(user, "Administrador")) {
                        return RedirectToAction("Index", "Administrador");

                    }
                }
                
                ModelState.AddModelError("","Usuario o clave incorrectos");
            }
            return View(lvm);
        }

        public async Task<IActionResult> Desactivador(int? id)
        {            
            if (id!=null) {
                var Usua = await _usuarioRepository.GetByIdAsync(id.Value);                
                Usua.Estado = "Inactivo";
                try {
                    await _usuarioRepository.Update(Usua);
                    

                } catch {
                    return RedirectToAction("Index");

                }
                return RedirectToAction("UsuarioDes", "Login");
                
            }
            return RedirectToAction("Index");

        }

        public IActionResult UsuarioDes() {

            return View();
        }


        public async Task<IActionResult> CerrarSesion()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Login");

        }

    }
}