using System;
using System.Collections.Generic;

namespace ItlaBanking.Models
{
    public partial class TarjetaCredito
    {
        public int NumeroTarjeta { get; set; }
        public decimal? MontoLimite { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }

        public decimal? Monto { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
    }
}
