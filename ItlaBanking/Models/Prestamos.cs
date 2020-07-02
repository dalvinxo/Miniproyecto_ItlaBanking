using System;
using System.Collections.Generic;

namespace ItlaBanking.Models
{
    public partial class Prestamos
    {
        public int NumeroPrestamo { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
    }
}
