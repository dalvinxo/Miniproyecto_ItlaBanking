using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using ItlaBanking.Repository;
using Microsoft.AspNetCore.Authorization;

namespace ItlaBanking.Controllers

{
    [Authorize(Roles ="Administrador")]
    public class AdministradorController : Controller
    {
        //conection db

        //repository
        private readonly UsuarioRepository _usuarioRepository;
        private readonly CuentaRepository _cuentaRepository;
        private readonly PrestamosRepository _prestamosRepository;
        private readonly TarjetaCreditoRepository _tarjetaCreditoRepository;
        

        //identity
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;


        public AdministradorController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
           UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository, PrestamosRepository prestamosRepository,
            TarjetaCreditoRepository tarjetaCreditoRepository
          )
        {
            _userManager = userManager;
            _signinManager = signInManager;
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;
            _tarjetaCreditoRepository = tarjetaCreditoRepository;
            _prestamosRepository = prestamosRepository;


        }
        public async Task<IActionResult> Index()
        {
            ViewData["Nombre"] =User.Identity.Name;

            //Total de clientes segun su estado.
            var TotalCLientActivos = await _usuarioRepository.GetCountUsuario("Activo");
            var TotalClientInactivos = await _usuarioRepository.GetCountUsuario("Inactivo");

            //Total de Productos por tipos
            var TotalCuenta = await _cuentaRepository.GetAllAsync();
            var TotalPrestamo = await _prestamosRepository.GetAllAsync();
            var TotalTarjeta = await _tarjetaCreditoRepository.GetAllAsync();
            
            //conversion client
            int CountClientesActivos = Convert.ToInt32(TotalCLientActivos.Count());
            int CountClientInactivos = Convert.ToInt32(TotalClientInactivos.Count());

            //conversion producto
            int CountProductCuenta = Convert.ToInt32(TotalCuenta.Count());
            int CountProductTarjeta = Convert.ToInt32(TotalTarjeta.Count());
            int CountProductoPrestamo = Convert.ToInt32(TotalPrestamo.Count());



            EstadisticaAdministradorViewModel estadistica = new EstadisticaAdministradorViewModel() {
    
                TotalClientActivos = CountClientesActivos,
                TotalClienteInactivos = CountClientInactivos,
                TotalCuenta = CountProductCuenta,
                TotalPrestamo = CountProductoPrestamo,
                TotalTarjeta = CountProductTarjeta

            };
            return View(estadistica);
        }


        public async Task<IActionResult> AdministrarUsuario()
        {
            ViewData["Nombre"] = User.Identity.Name;

            var ListaUsuarios = await _usuarioRepository.GetUsuarioOrder();
            
            return View(ListaUsuarios);

        }

        public async Task<IActionResult> Activador(int? id)
        {

              try
            {

                var Usuario = await _usuarioRepository.GetByIdAsync(id.Value);

                if (Usuario == null)
                {
                    return RedirectToAction("Error", "Home");
                }
                
                    if (Usuario.Estado == "Activo") {
                    Usuario.Estado = "Inactivo";
                }
                else {
                    Usuario.Estado = "Activo";
                }

                await _usuarioRepository.Update(Usuario);

            }
            catch
            {

                return RedirectToAction("Error", "Home");
            }

            return RedirectToAction("AdministrarUsuario","Administrador");

        }

     
    }
}