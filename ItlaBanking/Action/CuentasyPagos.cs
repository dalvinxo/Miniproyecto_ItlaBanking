using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItlaBanking.Models;
using ItlaBanking.Repository;
using ItlaBanking.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ItlaBanking.Action
{
    public class CuentasyPagos:Controller
    {

        private readonly ItlaBankingContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly CuentaRepository _cuentaRepository;
        private readonly TarjetaCreditoRepository _tarjetasRepository;
        private readonly PrestamosRepository _prestamosRepository;






        public CuentasyPagos(ItlaBankingContext context, UserManager<IdentityUser> userManager,
                            CuentaRepository cuentaRepository, TarjetaCreditoRepository tarjetasRepository,
                            PrestamosRepository prestamosRepository) {
            _context = context;
            _userManager = userManager;
            _cuentaRepository = cuentaRepository;
            _tarjetasRepository = tarjetasRepository;
            _prestamosRepository = prestamosRepository;
        }

        public PagosViewModel TraerCuentas(int? id) {
            
            
                PagosViewModel ptvm = new PagosViewModel();
                var CuentaList =  _context.Cuenta.Where(x => x.IdUsuario == id).ToList();
                var TarjetasList =  _context.TarjetaCredito.Where(x => x.IdUsuario == id).ToList();
                var PrestamosList =  _context.Prestamos.Where(x => x.IdUsuario == id).ToList();

            ptvm.cuenta = CuentaList;
            ptvm.tarjetas = TarjetasList;
            ptvm.prestamos = PrestamosList;


            return ptvm;

        }

        public BeneficiarioViewModel Beneficiarios(string user) {
            Usuario usu = new Usuario();
            usu =  _context.Usuario.FirstOrDefault(x => x.Usuario1 == user);
            BeneficiarioViewModel agg = new BeneficiarioViewModel();
            agg.IdUsuario = usu.IdUsuario;
            var list = new List<Cuenta>();
            var lista = new List<Usuario>();

            var beneficiarios =  _context.Beneficiario.Where(x => x.IdUsuarioCliente == usu.IdUsuario).ToList();
            foreach (var c in beneficiarios)
            {
                var cuenta =  _context.Cuenta.FirstOrDefault(x => x.IdUsuario == c.IdUsuarioBeneficiario);

                var usuarios = _context.Usuario.FirstOrDefault(x => x.IdUsuario == c.IdUsuarioBeneficiario);

                list.Add(cuenta);
                lista.Add(usuarios);

            }
            var cuentauser = _context.Cuenta.Where(x => x.IdUsuario == usu.IdUsuario).ToList();

            agg.cuenta = list;
            agg.usuario = lista;
            agg.cuentauser = cuentauser;
            return agg;
        }



        public async Task<PagosViewModel> PagoExpreso(PagosViewModel ptvm)
        {
            var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuenta);
            var cuenta2 = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuentaPagar);
            if (cuenta == null || cuenta2 == null)
            {
                ModelState.AddModelError("", "Cuenta Inexistente");

                return ptvm;
            }
            if (cuenta.Balance < ptvm.Monto)
            {
                ModelState.AddModelError("", "No tiene suficiente balance");
                return ptvm;

            }
            cuenta.Balance = cuenta.Balance - ptvm.Monto;
            cuenta2.Balance = cuenta2.Balance + ptvm.Monto;
            try
            {
                await _cuentaRepository.Update(cuenta);
                await _cuentaRepository.Update(cuenta2);
            }
            catch { }

            return null;

        }

        public async Task<PagosViewModel> PagoTarjeta(PagosViewModel ptvm)
        {
            var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuenta);
            var tarjeta = await _context.TarjetaCredito.FirstOrDefaultAsync(x => x.NumeroTarjeta == ptvm.NumeroCuentaPagar);
            if (cuenta == null || tarjeta == null)
            {
                ModelState.AddModelError("", "Cuenta Inexistente");

                return ptvm;
            }
            if (cuenta.Balance < ptvm.Monto)
            {
                ModelState.AddModelError("", "No tiene suficiente balance");
                return ptvm;

            }
            cuenta.Balance = cuenta.Balance - ptvm.Monto;

            if (tarjeta.Deuda > ptvm.Monto)
            {
                tarjeta.Deuda = tarjeta.Deuda - ptvm.Monto;
            }
            else if (tarjeta.Deuda < ptvm.Monto)
            {
                ptvm.Monto = ptvm.Monto - tarjeta.Deuda;
                tarjeta.Deuda = 0;
                cuenta.Balance = cuenta.Balance + ptvm.Monto;

            }
            try
            {
                await _cuentaRepository.Update(cuenta);
                await _tarjetasRepository.Update(tarjeta);
            }
            catch { }

            return null;

        }

        public async Task<PagosViewModel> PagoPrestamo(PagosViewModel ptvm)
        {
            var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroCuenta == ptvm.NumeroCuenta);
            var prestamo = await _context.Prestamos.FirstOrDefaultAsync(x => x.NumeroPrestamo == ptvm.NumeroCuentaPagar);
            if (cuenta == null || prestamo == null)
            {
                ModelState.AddModelError("", "Cuenta Inexistente");

                return ptvm;
            }
            if (cuenta.Balance < ptvm.Monto)
            {
                ModelState.AddModelError("", "No tiene suficiente balance");

                return ptvm;

            }
            cuenta.Balance = cuenta.Balance - ptvm.Monto;

            if (prestamo.Monto > ptvm.Monto)
            {
                prestamo.Monto = prestamo.Monto - ptvm.Monto;
            }
            else if (prestamo.Monto < ptvm.Monto)
            {
                ptvm.Monto = ptvm.Monto - prestamo.Monto;
                prestamo.Monto = 0;
                cuenta.Balance = cuenta.Balance + ptvm.Monto;

            }
            try
            {
                await _cuentaRepository.Update(cuenta);
                await _prestamosRepository.Update(prestamo);
            }
            catch { }

            return null;

        }
    }
}
