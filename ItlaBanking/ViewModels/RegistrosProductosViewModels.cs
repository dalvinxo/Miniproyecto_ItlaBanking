using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class RegistrosProductosViewModels
    {
        
        public int NumeroCuenta { get; set; }
        public int NumeroTarjeta { get; set; }
        public int NumeroPrestamo { get; set; }


        [Display(Name = "Seleccionar producto:")]
        [Required(ErrorMessage = "Este campo debe ser llenado")]
        public string TipoCuenta { get; set; }

        [Display(Name = "Digitar monto del prestamo:")]
        [Range(0, 99999999999.99, ErrorMessage = "Balance invalido; numero maximo de digitos 13.")]
        [Column(TypeName = "decimal(13, 2)")]
        [Required(ErrorMessage = "Debe digitar el monto deseado para este campo.")]
        public decimal? Monto { get; set; }

        [Display(Name = "Digitar monto limite de la tarjeta:")]
        [Range(0, 99999999999.99, ErrorMessage = "Balance invalido; numero maximo de digitos 13.")]
        [Column(TypeName = "decimal(13, 2)")]
        [Required(ErrorMessage = "Debe digitar el monto deseado para este campo.")]
        public decimal? MontoLimite { get; set; }

        [Display(Name = "Digitar monto inicial:")]
        [Range(0, 99999999999.99, ErrorMessage = "Balance invalido; numero maximo de digitos 13.")]
        [Column(TypeName = "decimal(13, 2)")]
        [Required(ErrorMessage = "Debe digitar el monto deseado para este campo.")]
        public decimal? Balance { get; set; }

        public DateTime? FechaExpiracion { get; set; }

        public int IdUsuario { get; set; }

        public DateTime? FechaAdquisicion { get; set; }

        public DateTime? FechaPago { get; set; }

        public int? Categoria { get; set; }

        public string Estado { get; set; }

    }

}
