using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return RedirectToAction("Index","Login");
        }

        public IActionResult AccessDenied()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}