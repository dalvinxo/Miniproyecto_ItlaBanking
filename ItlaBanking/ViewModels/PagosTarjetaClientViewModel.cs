using ItlaBanking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class PagosTarjetaClientViewModel
    {

        public IEnumerable<Cuenta> ListCuenta;

        public IEnumerable<TarjetaCredito> ListCredito;

        [Display(Name = "Digitar monto del prestamo:")]
        [Range(0, 9999999999.99, ErrorMessage = "Balance invalido; numero maximo de digitos 13.")]
        [Required(ErrorMessage = "Debe digitar el monto deseado para este campo.")]
        public decimal? Monto { get; set; }
        public int IdTransacciones { get; set; }
        public int? NumeroCuentaDestinatario { get; set; }
        public DateTime? Fecha { get; set; }
        public int NumeroCuenta { get; set; }


        public Cuenta NumeroCuentaNavigation { get; set; }

    }
}
