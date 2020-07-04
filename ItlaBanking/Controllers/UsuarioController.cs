
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly ItlaBankingContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        public UsuarioController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper){
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _mapper = mapper;
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

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(RegistroUsuarioViewModels rvm)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = rvm.Usuario1 };
                var result = await _userManager.CreateAsync(user, rvm.Clave);
                
                if (result.Succeeded){
                    var newUsuario = _mapper.Map<Usuario>(rvm);
                    _context.Add(newUsuario);
                    await _context.SaveChangesAsync();
                    await _signinManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Login");
                }
                AddErrors(result);
            }
            return View(rvm);
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

        

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }
    }
}