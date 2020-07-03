using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class LoginViewModel
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [Display(Name = "Usuario: ")]
        [StringLength(30)]
        public string Usuario1 { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña:")]
        [StringLength(25, ErrorMessage = "25 es la cantidad maxima de caracter de este campo")]
        public string Clave { get; set; }



    }
}
