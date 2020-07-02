using System;
using System.Collections.Generic;

namespace ItlaBanking.Models
{
    public partial class Beneficiario
    {
        public int IdUsuarioCliente { get; set; }
        public int IdUsuarioBeneficiario { get; set; }

        public Usuario IdUsuarioBeneficiarioNavigation { get; set; }
        public Usuario IdUsuarioClienteNavigation { get; set; }
    }
}
