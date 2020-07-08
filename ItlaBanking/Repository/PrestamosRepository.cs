using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class PrestamosRepository : RepositoryBase<Prestamos,ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;

        public PrestamosRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }
        
        

    }
}
