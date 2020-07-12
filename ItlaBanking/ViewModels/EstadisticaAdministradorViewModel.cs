using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class EstadisticaAdministradorViewModel
    {

        public int TotalTransacciones { get; set; }

        public int TransaccionesHoy { get; set; }

        public int TotalPagos { get; set; }

        public int PagosHoy { get; set; }

        public int TotalClientActivos { get; set; }

        public int TotalClienteInactivos { get; set; }

        public int TotalCuenta { get; set; }

        public int TotalTarjeta { get; set; }

        public int TotalPrestamo { get; set; }

        public IEnumerable<EstadisticaAdministradorViewModel> stats;

    }
}
