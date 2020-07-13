using ItlaBanking.Models;
using ItlaBanking.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.Repository
{
    public class CuentaRepository : RepositoryBase<Cuenta,ItlaBankingContext>
    {
        private readonly ItlaBankingContext _context;

        public CuentaRepository(ItlaBankingContext context) : base(context)
        {
            _context = context;
        }

        public Cuenta GetCuentaAt(int idusuario) {

            var code =  _context.Cuenta.FirstOrDefault(x => x.IdUsuario == idusuario && x.Categoria == 1);
            return code;
        }

        public async Task<IEnumerable<Cuenta>> GetCuentaUsuario(int id)
        {
            return await _context.Cuenta.Where(x => x.IdUsuario == id).OrderBy(x => x.Categoria).ToListAsync();
        }

        //public Cuenta Cuenta Destinatario(int idusuario)
        //{

        //    var code = _context.Cuenta.FirstOrDefault(x => x.IdUsuario == idusuario && x.Categoria == 1);
        //    return code;
        //}

        //public async Task<IEnumerable<Cuenta>> GetTotalProducto() {
        //    R
        //}


        //public async Task<List<Cuenta>> GetCuentaSpecific(){
        //var unicousuario = await GetAllAsync();
        //var usuario = await unicousuario.AsQueryable().Where(s => s.IdUsuario == 4).ToListAsync();
        //    return await _context.Cuenta.Where(x => x.IdUsuario < 5).ToListAsync();
        //}


    }
}
