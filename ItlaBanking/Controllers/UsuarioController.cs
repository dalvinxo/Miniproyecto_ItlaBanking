﻿
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
                    
                    var code = _context.Cuenta.FirstOrDefault(x=> x.NumeroCuenta == codigo);
                    if (code!=null )
                    {
                        goto A;
                    }
                    rvm.NumeroCuenta = codigo;

                    rvm.Categoria = 1;
                    rvm.IdUsuario = newUsuario.IdUsuario;

                    var newCuenta = _mapper.Map<Cuenta>(rvm);
                    await _cuentaRepository.AddAsync(newCuenta);

                    await _signinManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("AdministradorUsuario", "Administrador");
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

            return RedirectToAction("AdministradorUsuario","Administrador");
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
    }
}