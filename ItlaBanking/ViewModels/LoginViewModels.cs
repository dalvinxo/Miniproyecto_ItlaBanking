using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class LoginViewModels
    {

        [Required(ErrorMessage = "Debes colocar un usuario!")]
        [Display(Name = "User: ")]
        [StringLength(30)]
        public string Usuario1 { get; set; }

        [Required(ErrorMessage = "Debes colocar una contraseña!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        [StringLength(25)]
        public string Clave { get; set; }

    }
}
