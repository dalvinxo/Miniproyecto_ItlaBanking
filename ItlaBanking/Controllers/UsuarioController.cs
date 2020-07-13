
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ItlaBanking.Action;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItlaBanking.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class UsuarioController : Controller
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


        public UsuarioController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, PrestamosRepository prestamosRepository, CuentaRepository cuentaRepository, TarjetaCreditoRepository tarjetaCreditoRepository) {
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

        public IActionResult CrearProducto(int? id)
        {
            if (id != null) {
                RegistrosProductosViewModels pdt0 = new RegistrosProductosViewModels();
                pdt0.IdUsuario = Convert.ToInt32(id);
                return View(pdt0);

            }

            return RedirectToAction("AdministrarUsuario", "Administrador");
        }


        [HttpPost]
        public async Task<IActionResult> CrearProducto(RegistrosProductosViewModels pdt)
        {
            int? id = pdt.IdUsuario;


            GestionProductoUsuario Validar = new GestionProductoUsuario(_userManager,_signinManager,_context, _mapper, _usuarioRepository, _repositoryPrestamos, _cuentaRepository, _tarjetaCreditoRepository);
            var validacion = await Validar.ValidarProducto(pdt);

            if (validacion == null) {
                return RedirectToAction("Producto", "Usuario", new { @id = id });
            }

            return View(validacion);
            
        }
    

        public async Task<IActionResult> Producto(int? id) {

                int idusuarioentero = Convert.ToInt32(id);
                TraerProductosViewModels tpvm = new TraerProductosViewModels();
                var CuentaList = await _cuentaRepository.GetCuentaUsuario(idusuarioentero);
                var TarjetasList = await  _tarjetaCreditoRepository.GetCreditoUsuario(idusuarioentero);
                var PrestamosList = await _repositoryPrestamos.GetPrestamoUsuario(idusuarioentero);



                tpvm.Cuenta = CuentaList;
                tpvm.Credito = TarjetasList;
                tpvm.Prestamos = PrestamosList;

                tpvm.IdUsuario = Convert.ToInt32(id);
                

                return View(tpvm);
        }


        public IActionResult CrearUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearUsuario(RegistroUsuarioViewModels rvm)
        {
            if (ModelState.IsValid)
            {


                GestionProductoUsuario Validar = new GestionProductoUsuario(_userManager, _signinManager, _context, _mapper, _usuarioRepository, _repositoryPrestamos, _cuentaRepository, _tarjetaCreditoRepository);
                var Validacion = await Validar.CrearUsuario(rvm);

                if (Validacion != null) {
                    return View(Validacion);
                }
                return RedirectToAction("AdministrarUsuario", "Administrador");
                
            }
            return View(rvm);

        }

       
        public async Task<IActionResult> EditUsuario(int? id)
        {
            var UserEdit = await _usuarioRepository.GetByIdAsync(id.Value);
            if (UserEdit!=null) {
                var Usu = _mapper.Map<UpdateUsuarioViewModels>(UserEdit);
                return View(Usu);
                
            }

            return RedirectToAction("AdministrarUsuario","Administrador");
        }

        [HttpPost]
        public async Task<IActionResult> EditUsuario(UpdateUsuarioViewModels uvmd)
        {
            
                var valio = _usuarioRepository.UsuarioNoRepeat(uvmd.Usuario1);

                    if (valio != null)
                    {
                        
                              ModelState.AddModelError("", "Este usuario ya existe intenta con otro");
                                return View(uvmd);
                    } else {

                        if (ModelState.IsValid)
                        {
                            var mapeador = _mapper.Map<Usuario>(uvmd);
                            await _usuarioRepository.Update(mapeador);
                    try
                    {
                        var user = await _userManager.FindByNameAsync(uvmd.ValidationUsuario);
                        user.UserName = mapeador.Usuario1;

                        var up = await _userManager.UpdateAsync(user);
                        if (up.Succeeded)
                        {
                        }
                        else {
                            ModelState.AddModelError("", "Este usuario ya existe intenta con otro");
                            return View(uvmd);
                        }
                    }
                    catch {

                    }


                    var cuentaPrincipal = _cuentaRepository.GetCuentaAt(mapeador.IdUsuario);
                            if (uvmd.Balance == null) {
                                uvmd.Balance = 0;
                            }

                            cuentaPrincipal.Balance = cuentaPrincipal.Balance + uvmd.Balance.Value;
                            await _cuentaRepository.Update(cuentaPrincipal);


                            return RedirectToAction("AdministrarUsuario", "Administrador");
                        }
                        return View(uvmd);
                
                    }
                
        
        }
        
    }
}