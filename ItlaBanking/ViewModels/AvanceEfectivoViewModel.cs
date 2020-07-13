using ItlaBanking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class AvanceEfectivoViewModel
    {


        [Required(ErrorMessage = "El numero de cuenta no debe estar vacio")]
        public int? NumeroCuenta { get; set; }

        [Required(ErrorMessage = "El numero de cuenta no debe estar vacio")]
        public int? NumeroTarjeta { get; set; }       

        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})?$", ErrorMessage = "Por favor agregar numeros validos")]
        [Range(0, 99999999999.99, ErrorMessage = "la cantidad de dinero no pueder ser mayor a ser 13 digitos")]
        [Required(ErrorMessage = "El monto no debe estar vacio.")]
        public decimal? Monto { get; set; }
        
        public int? NumeroCuentaDestinatario { get; set; }
        public DateTime? Fecha { get; set; }
        public int TipoTransaccion { get; set; }

        public IEnumerable<Cuenta> cuenta;
        public IEnumerable<Cuenta> cuentaMismoCliente;

        public IEnumerable<TarjetaCredito> tarjetas;

    }
}
