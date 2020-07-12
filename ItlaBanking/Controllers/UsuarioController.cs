
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
<<<<<<< HEAD
            try { 
            if (pdt.TipoCuenta == "Ahorro")
            {
                if (pdt.Balance == null)
                {
                        //pdt.Balance = 0;
                        ModelState.AddModelError("null", "La cantidad insertada debe contener menos de 13 digitos, intentelo de nuevo");
                        return View(pdt);
                    }

            A:
                Random r = new Random();
                int codigo = r.Next(100000000, 999999999);

                if (!ValidarCodigo(codigo))
                {
                    goto A;
                }
                pdt.NumeroCuenta = codigo;
                              
                var newCuenta = _mapper.Map<Cuenta>(pdt);
                await _cuentaRepository.AddAsync(newCuenta);
                return RedirectToAction("Producto", "Usuario", new { @id = id });

            }
            else if (pdt.TipoCuenta == "Credito")
            {
                DateTime fecha = DateTime.Now;
                DateTime Pago = Convert.ToDateTime(fecha);
                DateTime FechaExpiracion = Convert.ToDateTime(fecha);
                Pago = Pago.AddDays(20);
                FechaExpiracion = FechaExpiracion.AddDays(30);
                pdt.Monto = 0;

                if (pdt.MontoLimite == null)
                {

                  //  pdt.MontoLimite = 0;
                    ModelState.AddModelError("","Necesita Ingresar el monto limite de esta tarjeta");
                    return View(pdt);

                }

            B:
                Random r = new Random();
                int codigo = r.Next(100000000, 999999999);

                if (!ValidarCodigo(codigo))
                {
                    goto B;
                }

                pdt.NumeroTarjeta = codigo;

                var newTarjeta = _mapper.Map<TarjetaCredito>(pdt);
                newTarjeta.FechaExpiracion = FechaExpiracion;
                newTarjeta.FechaPago = Pago;

               // await _context.TarjetaCredito.AddAsync(newTarjeta);
                await _context.SaveChangesAsync();
=======
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527

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

<<<<<<< HEAD
                if (rvm.Balance == null) {
                    rvm.Balance = 0;
                }
               
                var user = new IdentityUser { UserName = rvm.Usuario1 };
                var result = await _userManager.CreateAsync(user, rvm.Clave);
                
                if (rvm.TipoUsuario == "Administrador") {
                    await _userManager.AddToRoleAsync(user, "Administrador");

                }
                else if(rvm.TipoUsuario == "Cliente") {
                    await _userManager.AddToRoleAsync(user, "Cliente");

                }


                if (result.Succeeded){
                    var newUsuario = _mapper.Map<Usuario>(rvm);
                    await _usuarioRepository.AddAsync(newUsuario);

                A:
                    Random r = new Random();
                    int codigo = r.Next(100000000, 999999999);

                    if (!ValidarCodigo(codigo))
                    {
                        goto A;
                    }
                    rvm.NumeroCuenta = codigo;

                    rvm.Categoria = 1;
                    rvm.IdUsuario = newUsuario.IdUsuario;

                    var newCuenta = _mapper.Map<Cuenta>(rvm);
                    await _cuentaRepository.AddAsync(newCuenta);

                    return RedirectToAction("AdministrarUsuario", "Administrador");
=======
                GestionProductoUsuario Validar = new GestionProductoUsuario(_userManager, _signinManager, _context, _mapper, _usuarioRepository, _repositoryPrestamos, _cuentaRepository, _tarjetaCreditoRepository);
                var Validacion = await Validar.CrearUsuario(rvm);

                if (Validacion != null) {
                    return View(Validacion);
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
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