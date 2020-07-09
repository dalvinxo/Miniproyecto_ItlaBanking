using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class TarjetaCreditoRepository : RepositoryBase<TarjetaCredito,ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;

        public TarjetaCreditoRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<TarjetaCredito> GetCreditoUsuario(int id)
        {
            return _context.TarjetaCredito.Where(x => x.IdUsuario == id).OrderByDescending(x => x.FechaExpiracion).ToList();
        }


    }
}
