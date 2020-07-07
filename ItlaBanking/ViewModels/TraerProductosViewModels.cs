using ItlaBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class TraerProductosViewModels
    {
        public int IdUsuario { get; set; }

        public IEnumerable<Cuenta> Cuenta;

        public IEnumerable<TarjetaCredito> Credito;

        public IEnumerable<Prestamos> Prestamos;

    }
}
