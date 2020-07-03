using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModels user)
        {

            return View();
        }

    }
}