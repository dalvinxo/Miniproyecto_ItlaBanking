
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
    public class UsuarioController : Controller
    {

        private readonly ItlaBankingContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;


        //repository
        private readonly UsuarioRepository _usuarioRepository;
        private readonly CuentaRepository _cuentaRepository;

        public UsuarioController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,
            ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, CuentaRepository cuentaRepository){
            _userManager = userManager;
            _signinManager = signInManager;
            _context = context;
            _mapper = mapper;


            ///repositorios
            _usuarioRepository = usuarioRepository;
            _cuentaRepository = cuentaRepository;


        }

        public IActionResult CrearProducto(int? id)
        {
            if (id!=null) {
                RegistrosProductosViewModels pdt0 = new RegistrosProductosViewModels();
                pdt0.IdUsuario = Convert.ToInt32(id);
                return View(pdt0);

            }

            return RedirectToAction("AdministrarUsuario", "Administrador");
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto(RegistrosProductosViewModels pdt)
        {

            if (pdt.TipoCuenta == "Ahorro")
            {
                if (pdt.Balance == null)
                {
                    pdt.Balance = 0;
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
                return RedirectToAction("Producto", "Usuario",newCuenta.IdUsuario);

            }
            else if (pdt.TipoCuenta == "Credito")
            {
                if (pdt.MontoLimite == null)
                {
                    pdt.MontoLimite = 0;
                    //Eliam esto esta mal, recuerda ponerle el error como si fuera un data annotation
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
                await _context.TarjetaCredito.AddAsync(newTarjeta);
                await _context.SaveChangesAsync();

                //await _cuentaRepository.AddAsync(newCuenta);

                return RedirectToAction("Producto", "Usuario", newTarjeta.IdUsuario);


            }
            else if (pdt.TipoCuenta == "Prestamo")
            {
                if (pdt.Monto == null)
                {
                    pdt.Monto = 0;
                    //Eliam esto esta mal, recuerda ponerle el error como si fuera un data annotation
                }

            C:
                Random r = new Random();
                int codigo = r.Next(100000000, 999999999);
                if (!ValidarCodigo(codigo))
                {
                    goto C;
                }
                pdt.NumeroPrestamo = codigo;

                var newPrestamo = _mapper.Map<Prestamos>(pdt);
                await _context.Prestamos.AddAsync(newPrestamo);
                await _context.SaveChangesAsync();

                //await _cuentaRepository.AddAsync(newCuenta);

                return RedirectToAction("Producto", "Usuario", newPrestamo.IdUsuario);


            }
            else {
                return RedirectToAction("Error", "Home");

            }
        }

        public async Task<IActionResult> Producto(int? id) {
            if (id != null)
            {
                TraerProductosViewModels tpvm = new TraerProductosViewModels();
                var CuentaList = await _context.Cuenta.Where(x=>x.IdUsuario == id).ToListAsync();
                var TarjetasList = await _context.TarjetaCredito.Where(x => x.IdUsuario == id).ToListAsync();
                var PrestamosList = await _context.Prestamos.Where(x => x.IdUsuario == id).ToListAsync();

                tpvm.Cuenta = CuentaList;
                tpvm.Credito = TarjetasList;
                tpvm.Prestamos = PrestamosList;

                tpvm.IdUsuario = Convert.ToInt32(id);
                

                return View(tpvm);

            }

            return RedirectToAction("Error","Home");
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

                if (rvm.Balance == null) {
                    rvm.Balance = 0;
                }
               
                var user = new IdentityUser { UserName = rvm.Usuario1 };
                var result = await _userManager.CreateAsync(user, rvm.Clave);
                                               
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

                    await _signinManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("AdministrarUsuario", "Administrador");
                }
                AddErrors(result);
            }
            return View(rvm);
        }

        public async Task<IActionResult> EditUsuario(int? id)
        {
            //var UserEdit = await _context.Usuario.FirstOrDefaultAsync(x => x.IdUsuario== id);
            var UserEdit = await _usuarioRepository.GetByIdAsync(id.Value);
            if (UserEdit!=null) {
                var Usu = _mapper.Map<RegistroUsuarioViewModels>(UserEdit);

                return View(Usu);

            }

            return RedirectToAction("AdministrarUsuario","Administrador");
        }

        [HttpPost]
        public async Task<IActionResult> EditUsuario(RegistroUsuarioViewModels uvmd)
        {

           /* try
            {*/


                if (ModelState.IsValid) {
                    var mapeador = _mapper.Map<Usuario>(uvmd);
                //    var user = _context.Usuario.Attach(mapeador);
                //// user.State = EntityState.Modified;
                ////await  _context.SaveChangesAsync();
                await _usuarioRepository.Update(mapeador);
                var cuentaPrincipal = _cuentaRepository.GetCuentaAt(mapeador.IdUsuario);
                cuentaPrincipal.Balance = cuentaPrincipal.Balance+ uvmd.Balance;

                await _cuentaRepository.Update(cuentaPrincipal);
                
                //var idCuenta = _context.Cuenta.FirstOrDefault(x => x.IdUsuario == mapeador.IdUsuario && x.Categoria == 1);
                //await _context.Database.ExecuteSqlCommandAsync("Procedur @Do={0}, @idCuenta={1}, @Balance={2}","SumBalance", idCuenta.NumeroCuenta, uvmd.Balance);

                return RedirectToAction("AdministrarUsuario", "Administrador");
                }
                return View(uvmd);

            /*}
            catch
            {
                return RedirectToAction("Index", "Login");
            }*/
        }

        

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        private bool ValidarCodigo(int codigo) {
            var code = _context.Cuenta.FirstOrDefault(x => x.NumeroCuenta == codigo);
            var code2 = _context.Prestamos.FirstOrDefault(x => x.NumeroPrestamo == codigo);
            var code3 = _context.TarjetaCredito.FirstOrDefault(x => x.NumeroTarjeta == codigo);

            if (code != null && code2 != null && code3 != null)
            {
                return false;
            }
            return true;
        }
    }
}