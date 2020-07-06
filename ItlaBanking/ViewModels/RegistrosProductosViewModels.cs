using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class RegistrosProductosViewModels
    {
        
        public int NumeroCuenta { get; set; }

        [Display(Name = "Seleccionar producto:")]
        [Required(ErrorMessage = "Este campo debe ser llenado")]
        public string TipoCuenta { get; set; }

        [Display(Name = "Digitar monto del prestamo:")]
        [StringLength(13, ErrorMessage = "Ha alcanzado el punto maximo de carácteres")]
        [Required(ErrorMessage = "Este campo debe ser llenado")]
        public decimal? Monto { get; set; }

        [Display(Name = "Digitar monto limite de la tarjeta:")]
        [StringLength(13, ErrorMessage = "Ha alcanzado el punto maximo de carácteres")]
        [Required(ErrorMessage = "Este campo debe ser llenado")]
        public decimal? MontoLimite { get; set; }

        [Display(Name = "Digitar monto inicial:")]
        [StringLength(13, ErrorMessage = "Ha alcanzado el punto maximo de carácteres")]
        [Required(ErrorMessage = "Este campo debe ser llenado")]
        public decimal? Balance { get; set; }

        public DateTime? FechaExpiracion { get; set; }

        public int IdUsuario { get; set; }

        public DateTime? FechaAdquisicion { get; set; }

        public DateTime? FechaPago { get; set; }

        public int? Categoria { get; set; }

        public string Estado { get; set; }

    }

}
