using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class TransaccionesRepository : RepositoryBase<Transacciones,ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;

        public TransaccionesRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }

        

    }
}
