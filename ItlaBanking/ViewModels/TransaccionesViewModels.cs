using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class TransaccionesViewModels
    {
        public int IdTransacciones { get; set; }
        public decimal? Monto { get; set; }
        public int? NumeroCuentaDestinatario { get; set; }
        public DateTime? Fecha { get; set; }
        public int NumeroCuenta { get; set; }
        public int TipoTransaccion { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

    }
}
