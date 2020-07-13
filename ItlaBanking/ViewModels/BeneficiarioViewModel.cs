using ItlaBanking.Models;
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class BeneficiarioViewModel
    {
        public int IdUsuario { get; set; }


        [Required(ErrorMessage ="Este campo no puede estar vacio")]
        public int? NumeroCuenta { get; set; }
        
        public int? NumeroCuentaPagar { get; set; }

        public decimal? Monto { get; set; }

        public IEnumerable<Cuenta> cuenta;
        public IEnumerable<Cuenta> cuentauser;

        public List<ProbandoBeneficiarioViewModel> LosBeneficiarios;

        public IEnumerable<BeneficiarioProdureViewModel> beneficiariosprocedure;


        public IEnumerable<Usuario> usuario;

    }
}
