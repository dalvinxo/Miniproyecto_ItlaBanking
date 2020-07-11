using ItlaBanking.Models;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
=======
using System;
using System.Collections.Generic;
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class BeneficiarioViewModel
    {
        public int IdUsuario { get; set; }

<<<<<<< HEAD
        //[Remote(action: "VerifiBeneficiario", controller:"Client")]
        //[Required(ErrorMessage ="Este campo no puede estar vacio")]
=======
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e
        public int? NumeroCuenta { get; set; }
        
        public int? NumeroCuentaPagar { get; set; }

<<<<<<< HEAD
       
=======

>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e
        public decimal? Monto { get; set; }

        public IEnumerable<Cuenta> cuenta;
        public IEnumerable<Cuenta> cuentauser;

<<<<<<< HEAD
        public List<ProbandoBeneficiarioViewModel> LosBeneficiarios;

        public IEnumerable<BeneficiarioProdureViewModel> beneficiariosprocedure;
=======
>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e

        public IEnumerable<Usuario> usuario;

    }
}
