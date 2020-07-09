
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
    public class ProductoController : Controller
    {

        private readonly ItlaBankingContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;


        //repository
        private readonly UsuarioRepository _usuarioRepository;
        private readonly CuentaRepository _cuentaRepository;
        private readonly PrestamosRepository _repositoryPrestamos;
        private readonly TarjetaCreditoRepository _tarjetaCreditoRepository;


        public ProductoController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, PrestamosRepository prestamosRepository, CuentaRepository cuentaRepository, TarjetaCreditoRepository tarjetaCreditoRepository){
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _mapper = mapper;


            ///repositorios
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;
            _repositoryPrestamos = prestamosRepository;
            _tarjetaCreditoRepository = tarjetaCreditoRepository;
        }

        public async Task<IActionResult> DeletePrestamo(int IdUsuario, int IdCuenta) {

            await _repositoryPrestamos.Delete(IdCuenta);

            return RedirectToAction("Producto", "Usuario", new { @id = IdUsuario});
        }

        public async Task<IActionResult> DeleteTarjeta(int IdUsuario, int IdCuenta)
        {
            
            await _tarjetaCreditoRepository.Delete(IdCuenta);

            return RedirectToAction("Producto", "Usuario", new { @id = IdUsuario});
        }


        public async Task<IActionResult> DeleteCuentaAhorro(int IdUsuario, int IdCuenta)
        {
            
            var cuenta = await _cuentaRepository.GetByIdAsync(IdCuenta);
            decimal MontoCuentaEliminada = Convert.ToDecimal(cuenta.Balance);

            var cuentaPrincipal =  _cuentaRepository.GetCuentaAt(IdUsuario);
            decimal MontoCuentaPrincipal = Convert.ToDecimal(cuentaPrincipal.Balance);

            decimal total = MontoCuentaPrincipal + MontoCuentaEliminada;
            cuentaPrincipal.Balance = total;

            await _cuentaRepository.Update(cuentaPrincipal);

            await _cuentaRepository.Delete(IdCuenta);

            return RedirectToAction("Producto", "Usuario", new { @id = IdUsuario });
        }


    }

}