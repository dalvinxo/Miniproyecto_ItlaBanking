using System;
using System.Collections.Generic;

namespace ItlaBanking.Models
{
    public partial class Transacciones
    {
        public int IdTransacciones { get; set; }
        public decimal? Monto { get; set; }
        public int? NumeroCuentaDestinatario { get; set; }
        public DateTime? Fecha { get; set; }
        public int NumeroCuenta { get; set; }

        public Cuenta NumeroCuentaNavigation { get; set; }
    }
}
