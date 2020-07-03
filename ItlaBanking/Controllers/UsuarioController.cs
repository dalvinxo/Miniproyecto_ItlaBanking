using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly ItlaBankingContext _context;

        public UsuarioController(ItlaBankingContext context)
        {
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



        [HttpPost]
        public async Task<IActionResult> CrearUsuario(RegistroUsuarioViewModels usuario)
        {

            return RedirectToAction("AdministrarUsuario", "Administrador");
        }
    }
}