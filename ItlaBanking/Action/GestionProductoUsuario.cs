using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Action
{
    public class GestionProductoUsuario:Controller
    {
        private readonly ItlaBankingContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signinManager;

        private readonly UsuarioRepository _usuarioRepository;
        private readonly CuentaRepository _cuentaRepository;
        private readonly PrestamosRepository _repositoryPrestamos;
        private readonly TarjetaCreditoRepository _tarjetaCreditoRepository;


        public GestionProductoUsuario(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ItlaBankingContext context, IMapper mapper, UsuarioRepository usuarioRepository, PrestamosRepository prestamosRepository, CuentaRepository cuentaRepository, TarjetaCreditoRepository tarjetaCreditoRepository)
        {
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


        public async Task<RegistrosProductosViewModels> ValidarProducto(RegistrosProductosViewModels pdt)
        {
            int? id = pdt.IdUsuario;
            try
            {
                if (pdt.TipoCuenta == "Ahorro")
                {

                    if (pdt.Balance == null)
                    {
                        //pdt.Balance = 0;
                        ModelState.AddModelError("", "La cantidad insertada debe contener menos de 13 digitos, intentelo de nuevo");
                        return pdt;
                    }

                    if (pdt.Balance < 0)
                    {
                        ModelState.AddModelError("", "La cantidad no pueder ser negativa.");
                        return pdt;
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
                    return null;

                }
                else if (pdt.TipoCuenta == "Credito")
                {
                    DateTime fecha = DateTime.Now;
                    DateTime Pago = Convert.ToDateTime(fecha);
                    DateTime FechaExpiracion = Convert.ToDateTime(fecha);
                    Pago = Pago.AddDays(20);
                    FechaExpiracion = FechaExpiracion.AddDays(30);

                    if (pdt.MontoLimite == null)
                    {

                        //  pdt.MontoLimite = 0;
                        ModelState.AddModelError("", "Necesita Ingresar el monto limite de esta tarjeta");
                        return pdt;

                    }

                    if (pdt.MontoLimite < 0)
                    {
                        ModelState.AddModelError("", "La cantidad no pueder ser negativa.");
                        return pdt;
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

                    await _tarjetaCreditoRepository.AddAsync(newTarjeta);
                    //await _cuentaRepository.AddAsync(newCuenta);

                    return null;


                }
                else if (pdt.TipoCuenta == "Prestamo")
                {
                    DateTime fecha = DateTime.Now;
                    DateTime nuevaFecha = Convert.ToDateTime(fecha);
                    nuevaFecha = nuevaFecha.AddDays(30);

                    if (pdt.Monto == null)
                    {
                        //    pdt.Monto = 0;
                        ModelState.AddModelError("", "Necesita Ingresar el monto del prestamo");
                        return pdt;

                    }


                    if (pdt.Monto < 0)
                    {
                        ModelState.AddModelError("", "La cantidad no pueder ser negativa.");
                        return pdt;
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
                    newPrestamo.FechaExpiracion = nuevaFecha;


                    //Agrando monto prestamo a cuenta principal
                    decimal MontoPrestamo = Convert.ToDecimal(newPrestamo.Monto);

                    var cuentaPrincipal = _cuentaRepository.GetCuentaAt(id.Value);
                    decimal MontoCuentaPrincipal = Convert.ToDecimal(cuentaPrincipal.Balance);

                    decimal total = MontoCuentaPrincipal + MontoPrestamo;
                    cuentaPrincipal.Balance = total;

                    await _cuentaRepository.Update(cuentaPrincipal);

                    await _repositoryPrestamos.AddAsync(newPrestamo);


                    return null;

                }
                ModelState.AddModelError("", "Debes agregar algo por favor");
                return null;

            }
            catch(Exception e)
            {
                ModelState.AddModelError("",""+ e);
                return null;
            }

        }


        //Usuario
        public async Task<RegistroUsuarioViewModels> CrearUsuario(RegistroUsuarioViewModels rvm)
        {
           
                if (rvm.Balance == null)
                {
                    rvm.Balance = 0;
                }

                var user = new IdentityUser { UserName = rvm.Usuario1 };
                var result = await _userManager.CreateAsync(user, rvm.Clave);

                if (result.Succeeded)
                {
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

                    return null;
                }
            AddErrors(result);

            return rvm;
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }


        public bool ValidarCodigo(int codigo)
        {
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
