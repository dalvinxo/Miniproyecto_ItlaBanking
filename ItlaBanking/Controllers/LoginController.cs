﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItlaBanking.Models;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class LoginController : Controller
    {

        private readonly ItlaBankingContext _context;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ItlaBankingContext context)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;


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

            if (ModelState.IsValid) {
                var result = await _signinManager.PasswordSignInAsync(lvm.Usuario1, lvm.Clave, false,false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(lvm.Usuario1);
                    

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


        public async Task<IActionResult> CerrarSesion()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Login");

        }

    }
}