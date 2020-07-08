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
        public UsuarioRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> GetUsuarioOrder()
        {

            //var unicousuario = await GetAllAsync();

            //var usuario = await unicousuario.AsQueryable().Where(s => s.IdUsuario == 4).ToListAsync();
            
            return await _context.Usuario.OrderByDescending(x=> x.TipoUsuario == "Administrador").ToListAsync();
        }

      



    }


}
