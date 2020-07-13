using ItlaBanking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class BeneficiarioRepository : RepositoryBase<Beneficiario,ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;

        public BeneficiarioRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }

        public Beneficiario GetBeneficiarios(int idb, int c )
        {
            var code = _context.Beneficiario.FirstOrDefault(x => x.IdUsuarioBeneficiario == idb && x.CuentaBeneficiario == c);
            return code;
        }
        
        public Beneficiario ValidandoBeneficiarios(int a, int b, int c)
        {
            var code = _context.Beneficiario.FirstOrDefault(x => x.IdUsuarioCliente == a && x.IdUsuarioBeneficiario == b && x.CuentaBeneficiario == c);
            return code;
        }


    }
}
