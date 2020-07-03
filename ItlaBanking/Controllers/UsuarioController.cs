using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ItlaBanking.ViewModels;


namespace ItlaBanking.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly ItlaBankingContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public UsuarioController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
        }

        public async Task<IActionResult> CrearProducto()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto(RegistrosProductosViewModels producto)
        {


            return View();
        }

        public async Task<IActionResult> Producto()
        {


            return View();
        }


        public async Task<IActionResult> CrearUsuario()
        {

            return View();
        }

        public async Task<IActionResult> EditUsuario()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditUsuario(RegistrosProductosViewModels uvmd)
        {



            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(RegistroUsuarioViewModels rvm) {


            var user = new IdentityUser { UserName = rvm.Usuario1 };
            var result = await _userManager.CreateAsync(user, rvm.Clave);

            if (result.Succeeded)
            {
                await _signinManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Login");
            }
            AddErrors(result);
            return RedirectToAction("Index", "Client");


        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}