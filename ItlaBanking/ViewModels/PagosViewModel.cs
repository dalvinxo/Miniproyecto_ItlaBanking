using ItlaBanking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class PagosViewModel
    {
        //public int IdUsuario;

        //[Required]
        public int? NumeroCuenta { get; set; }

        [Required]
        public int? NumeroCuentaPagar { get; set; }

        [Required]
        public decimal? Monto { get; set; }


        public IEnumerable<Prestamos> prestamos;

        public IEnumerable<Cuenta> cuenta;

        public IEnumerable<TarjetaCredito> tarjetas;


    }


}
