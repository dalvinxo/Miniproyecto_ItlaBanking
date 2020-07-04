using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly ItlaBankingContext _context;

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public AdministradorController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context)
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;


        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> AdministrarUsuario()
        {
            var ListaUsuarios = await _context.Usuario.ToListAsync();
            
            return View(ListaUsuarios);

        }

        
    }
}