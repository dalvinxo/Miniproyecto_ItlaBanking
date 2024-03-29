﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly TransaccionesRepository _transaccionesRepository;
        private readonly IMapper _mapper;


        private readonly UsuarioRepository _usuarioRepository;






        public CuentasyPagos(ItlaBankingContext context, UserManager<IdentityUser> userManager,
                            CuentaRepository cuentaRepository, TarjetaCreditoRepository tarjetasRepository,
                            PrestamosRepository prestamosRepository, UsuarioRepository usuarioRepository,
                            TransaccionesRepository transaccionesRepository, IMapper mapper) {
            _context = context;
            _userManager = userManager;
            _cuentaRepository = cuentaRepository;
            _tarjetasRepository = tarjetasRepository;
            _prestamosRepository = prestamosRepository;
            _usuarioRepository = usuarioRepository;
            _transaccionesRepository = transaccionesRepository;
            _mapper = mapper;
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

        public async Task<BeneficiarioViewModel> Beneficiarios(string user) {
            Usuario usu = new Usuario();
            usu =  _context.Usuario.FirstOrDefault(x => x.Usuario1 == user);
            BeneficiarioViewModel agg = new BeneficiarioViewModel();
            agg.IdUsuario = usu.IdUsuario;
            var list = new List<Cuenta>();
            var lista = new List<Usuario>();

            var beneficiarios =  await _context.Beneficiario.Where(x => x.IdUsuarioCliente == usu.IdUsuario).ToListAsync();
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
            else if (tarjeta.Deuda <= ptvm.Monto)
            {
                ptvm.Monto = ptvm.Monto - tarjeta.Deuda;
                tarjeta.Deuda = 0;
                cuenta.Balance = cuenta.Balance + ptvm.Monto;

            }
            try
            {
                var UsuarioDestinatario = await _usuarioRepository.GetByIdAsync(cuenta.IdUsuario);

                TransaccionesViewModels Transacciones = new TransaccionesViewModels();
                Transacciones.NumeroCuenta = cuenta.NumeroCuenta;
                Transacciones.NumeroCuentaDestinatario = tarjeta.NumeroTarjeta;
                Transacciones.Monto = ptvm.Monto;
                Transacciones.Nombre = UsuarioDestinatario.Nombre;
                Transacciones.Apellido = UsuarioDestinatario.Apellido;
                Transacciones.TipoTransaccion = 1;
                
                var transacciones = _mapper.Map<Transacciones>(Transacciones);

                await _transaccionesRepository.AddAsync(transacciones);
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
            var tarjeta = await _context.TarjetaCredito.FirstOrDefaultAsync(x => x.NumeroTarjeta == ptvm.NumeroCuenta);
            if (tarjeta!=null) {
                 return await PagoPrestamoconTarjeta(ptvm, tarjeta, prestamo);
            }
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
            else if (prestamo.Monto <= ptvm.Monto)
            {
                ptvm.Monto = ptvm.Monto - prestamo.Monto;
                prestamo.Monto = 0;
                cuenta.Balance = cuenta.Balance + ptvm.Monto;

            }
            try
            {
                var UsuarioDestinatario = await _usuarioRepository.GetByIdAsync(cuenta.IdUsuario);

                TransaccionesViewModels Transacciones = new TransaccionesViewModels();
                Transacciones.NumeroCuenta = cuenta.NumeroCuenta;
                Transacciones.NumeroCuentaDestinatario = prestamo.NumeroPrestamo;
                Transacciones.Monto = ptvm.Monto;
                Transacciones.Nombre = UsuarioDestinatario.Nombre;
                Transacciones.Apellido = UsuarioDestinatario.Apellido;
                Transacciones.TipoTransaccion = 1;
                await _cuentaRepository.Update(cuenta);
                await _prestamosRepository.Update(prestamo);
                var transacciones = _mapper.Map<Transacciones>(Transacciones);

                await _transaccionesRepository.AddAsync(transacciones);
            }
            catch { }

            return null;

        }

        public async Task<PagosViewModel> PagoPrestamoconTarjeta(PagosViewModel ptvm, 
            TarjetaCredito tarjeta, Prestamos prestamo)
        {
           
            
            if (tarjeta.MontoLimite < ptvm.Monto)
            {
                ModelState.AddModelError("", "Sobrepasa el limite de su tarjeta");

                return ptvm;

            }
            if (tarjeta.Deuda + ptvm.Monto > tarjeta.MontoLimite) {
                ModelState.AddModelError("", "Sobrepasa el limite de su tarjeta");

                return ptvm;
            }
            tarjeta.Deuda = tarjeta.Deuda + ptvm.Monto;

            if (prestamo.Monto > ptvm.Monto)
            {
                prestamo.Monto = prestamo.Monto - ptvm.Monto;
            }
            else if (prestamo.Monto <= ptvm.Monto)
            {
                ptvm.Monto = ptvm.Monto - prestamo.Monto;
                prestamo.Monto = 0;
                tarjeta.Deuda = tarjeta.Deuda - ptvm.Monto;
                
            }
            await _tarjetasRepository.Update(tarjeta);
            await _prestamosRepository.Update(prestamo);

            return null;

        }
    }
}
