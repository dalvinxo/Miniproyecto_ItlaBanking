using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class UsuarioController : Controller
    {

        private readonly ItlaBankingContext _context;
        private readonly IMapper _mapper;

        public UsuarioController(ItlaBankingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult CrearUsuario()
        {

            return View();
        }
    }
}