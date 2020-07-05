using ItlaBanking.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ItlaBanking.ViewModels
{
    public class RegistroUsuarioViewModels
    {

        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [Display(Name = "Nombre:")]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [Display(Name = "Apellido:")]
        [StringLength(45)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [Display(Name = "Cédula:")]
        [StringLength(11)]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [Display(Name = "Correo:")]
        [StringLength(35)]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [Usuario(ErrorMessage = "Este usuario ya existe!")]
        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [Display(Name = "Usuario: ")]
        [StringLength(30)]
        public string Usuario1 { get; set; }

        [Required(ErrorMessage = "Este campo debe ser llenado")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña:")]
        [StringLength(25, ErrorMessage = "25 es la cantidad maxima de caracter de este campo")]
        public string Clave { get; set; }

        [Display(Name = "Confirmar Contraseña:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirmar La Contraseña")]
        [Compare(nameof(Clave), ErrorMessage = "La confirmación no se parece a la contraseña!")]
        public string ConfirmClave { get; set; }


        [Display(Name = "Seleccionar tipo de usuario:")]
        //[Required(ErrorMessage = "Este campo debe ser llenado")]
        public string TipoUsuario { get; set; }

        [Display(Name = "Balance:")]
        [DataType(DataType.Currency)]
        public decimal? Balance { get; set; }


        public int NumeroCuenta { get; set; }

        public int? Categoria { get; set;  }

        public string Estado { get; set; }

        public DateTime? FechaAdquisicion { get; set; }



    }

    public class UsuarioAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            if (value != null) {
                ItlaBankingContext _context = new ItlaBankingContext();
                var ListUsuario = _context.Usuario.Select(x => x.Usuario1).ToList();
               
                    if (ListUsuario.Contains(value))
                    {
                        return false;
                    }

                
                    return true;
                }

            return false;
            

        }
    }
    

}
