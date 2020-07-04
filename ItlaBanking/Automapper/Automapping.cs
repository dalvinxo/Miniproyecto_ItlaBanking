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

        private void MapearRegistro()
        {
            CreateMap<RegistroUsuarioViewModels, Usuario>().ReverseMap().
            ForMember(dest => dest.Balance, opt => opt.Ignore()).
            ForMember(dest => dest.ConfirmClave, opt => opt.Ignore());
            //.ReverseMap()ForMember(dest=>dest.Campo, opt => opt.Ignore());

        }
    }
}
