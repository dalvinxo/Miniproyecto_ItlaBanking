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
        

    }
}
