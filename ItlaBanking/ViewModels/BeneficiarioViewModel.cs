using ItlaBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class BeneficiarioViewModel
    {
        public int IdUsuario { get; set; }

        public int? NumeroCuenta { get; set; }
        
        public int? NumeroCuentaPagar { get; set; }


        public decimal? Monto { get; set; }

        public IEnumerable<Cuenta> cuenta;
        public IEnumerable<Cuenta> cuentauser;


        public IEnumerable<Usuario> usuario;

    }
}
