using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class TarjetadeUsuario : RepositoryBase<TarjetaCredito,ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;

        public TarjetadeUsuario(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<int>> TodasTarjetaUsuario(int IdUser) {

            return await _context.TarjetaCredito.Where(c => c.IdUsuario == IdUser).Select(x => x.NumeroTarjeta).ToListAsync();
        }


    }
}
