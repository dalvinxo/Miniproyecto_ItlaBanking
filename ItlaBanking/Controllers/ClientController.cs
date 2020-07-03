using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ItlaBanking.Controllers
{
    public class ClientController : Controller
    {

        //Vistas Gets home y beneficiario.
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beneficiario()
        {
            return View();
        }


        //Pagos 
        public IActionResult PagosExpreso()
        {
            return View();
        }

        public IActionResult PagosTarjeta()
        {
            return View();
        }

        public IActionResult PagosPrestamo()
        {
            return View();
        }

        public IActionResult PagosBeneficiario()
        {
            return View();
        }

        //OtrasVista
        public IActionResult AvanceEfectivo()
        {
            return View();
        }
        
        public IActionResult Transferencia()
        {
            return View();
        }


    }
}
