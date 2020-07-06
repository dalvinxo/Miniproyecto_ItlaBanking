using AutoMapper;
using ItlaBanking.Models;
using ItlaBanking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Automapper
{
    public class Automapping : Profile

    {
        public Automapping(){
            MapearRegistro();
            MapearCuenta();
            MapearARegistro();
            MapearCuentaProducto();
            MapearTarjetaProducto();
            MapearPrestamoProducto();



        }

        private void MapearPrestamoProducto()
        {
            CreateMap<RegistrosProductosViewModels, Prestamos>().ReverseMap().
                                    ForMember(dest => dest.NumeroCuenta, opt => opt.Ignore()).
                                    ForMember(dest => dest.TipoCuenta, opt => opt.Ignore()).
                                    ForMember(dest => dest.NumeroTarjeta, opt => opt.Ignore()).
                                    ForMember(dest => dest.MontoLimite, opt => opt.Ignore()).
                                    ForMember(dest => dest.Balance, opt => opt.Ignore()).
                                    ForMember(dest => dest.FechaPago, opt => opt.Ignore()).
                                    ForMember(dest => dest.FechaAdquisicion, opt => opt.Ignore()).
                                    ForMember(dest => dest.Categoria, opt => opt.Ignore())


                                    ;
        }

        private void MapearTarjetaProducto()
        {
            CreateMap<RegistrosProductosViewModels, TarjetaCredito>().ReverseMap().
                        ForMember(dest => dest.NumeroCuenta, opt => opt.Ignore()).
                        ForMember(dest => dest.TipoCuenta, opt => opt.Ignore()).
                        ForMember(dest => dest.Monto, opt => opt.Ignore()).
                        ForMember(dest => dest.Balance, opt => opt.Ignore()).
                        ForMember(dest => dest.FechaAdquisicion, opt => opt.Ignore()).
                        ForMember(dest => dest.Categoria, opt => opt.Ignore()).
                        ForMember(dest => dest.NumeroPrestamo, opt => opt.Ignore())



                        ;
        }

        private void MapearARegistro()
        {
            CreateMap<Usuario, RegistroUsuarioViewModels>().ReverseMap();
        }

        private void MapearCuenta()
        {
            CreateMap<RegistroUsuarioViewModels, Cuenta>().ReverseMap().
                        ForMember(dest => dest.Nombre, opt => opt.Ignore()).
                        ForMember(dest => dest.Apellido, opt => opt.Ignore()).
                        ForMember(dest => dest.Clave, opt => opt.Ignore()).
                        ForMember(dest => dest.ConfirmClave, opt => opt.Ignore()).
                        ForMember(dest => dest.Correo, opt => opt.Ignore()).
                        ForMember(dest => dest.TipoUsuario, opt => opt.Ignore()).
                        ForMember(dest => dest.Usuario1, opt => opt.Ignore()).
                        ForMember(dest => dest.Estado, opt => opt.Ignore())
                        

                        ;
        }

        private void MapearCuentaProducto()
        {
            CreateMap<RegistrosProductosViewModels, Cuenta>().ReverseMap().
                        ForMember(dest => dest.TipoCuenta, opt => opt.Ignore()).
                        ForMember(dest => dest.Monto, opt => opt.Ignore()).
                        ForMember(dest => dest.MontoLimite, opt => opt.Ignore()).
                        ForMember(dest => dest.FechaExpiracion, opt => opt.Ignore()).
                        ForMember(dest => dest.FechaPago, opt => opt.Ignore()).
                        ForMember(dest => dest.Estado, opt => opt.Ignore()).
                        ForMember(dest => dest.NumeroPrestamo, opt => opt.Ignore()).
                        ForMember(dest => dest.NumeroTarjeta, opt => opt.Ignore())




                        ;
        }

        private void MapearRegistro()
        {
            CreateMap<RegistroUsuarioViewModels, Usuario>().ReverseMap().
            ForMember(dest => dest.Balance, opt => opt.Ignore()).
            ForMember(dest => dest.ConfirmClave, opt => opt.Ignore());
            //.ReverseMap()ForMember(dest=>dest.Campo, opt => opt.Ignore());

        }
    }
}
