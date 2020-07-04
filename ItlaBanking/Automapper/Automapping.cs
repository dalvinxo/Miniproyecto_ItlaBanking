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
        }
        private void MapearRegistro()
        {
            CreateMap<RegistroUsuarioViewModels, Usuario>().ReverseMap().
            ForMember(dest => dest.monto, opt => opt.Ignore()).
            ForMember(dest => dest.ConfirmClave, opt => opt.Ignore())
            ;
            //.ReverseMap()ForMember(dest=>dest.Campo, opt => opt.Ignore());

        }
    }
}
