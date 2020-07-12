using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class ProbandoBeneficiarioViewModel
    {

        public int IdUsuarioCliente { get; set; }
        public int IdUsuarioBeneficiario { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor agregar numeros validos")]
        [Range(100000000, 999999999, ErrorMessage = "la cantidad de numeros para numero de cuenta debe ser 9 digitos")]
        [Required(ErrorMessage ="Debes Enviar un numero de cuenta.")]
        public int CuentaBeneficiario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }



    }
}
