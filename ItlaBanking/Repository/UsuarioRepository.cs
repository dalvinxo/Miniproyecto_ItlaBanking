using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario, ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;
        private TarjetadeUsuario TarjetadeUsuario;

        public UsuarioRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
            TarjetadeUsuario = new TarjetadeUsuario(context);
        }

        public async Task<List<Usuario>> GetUsuarioOrder()
        {            
            return await _context.Usuario.OrderByDescending(x=> x.TipoUsuario == "Administrador").ToListAsync();
        }

        public Usuario GetUsuarioAt(int idusuario)
        {
            var code = _context.Usuario.FirstOrDefault(x => x.IdUsuario == idusuario);
            return code;
        }


        public async Task<IEnumerable<Usuario>> GetCountUsuario(string estado) {

            if (estado =="Activo") {

                return await _context.Usuario.Where(x => x.Estado == "Activo").ToListAsync();

            } else {
                return await _context.Usuario.Where(x => x.Estado == "Inactivo").ToListAsync();

            }


        }


        public async Task<IEnumerable<TarjetaCredito>> GetUsuarioTarjetaCreditoId( int IdUsuario) {


            return null;

        }



        //var unicousuario = await GetAllAsync();

        //var usuario = await unicousuario.AsQueryable().Where(s => s.IdUsuario == 4).ToListAsync();


    }


}
