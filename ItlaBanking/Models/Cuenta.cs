using System;
using System.Collections.Generic;

namespace ItlaBanking.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            Transacciones = new HashSet<Transacciones>();
        }

        public int NumeroCuenta { get; set; }
        public decimal? Balance { get; set; }
        public int? Categoria { get; set; }
        public DateTime? FechaPago { get; set; }
        public DateTime? FechaAdquisicion { get; set; }
        public int IdUsuario { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<Transacciones> Transacciones { get; set; }
    }
}
