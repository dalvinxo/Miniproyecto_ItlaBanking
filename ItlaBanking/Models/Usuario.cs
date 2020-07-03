using System;
using System.Collections.Generic;

namespace ItlaBanking.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            BeneficiarioIdUsuarioBeneficiarioNavigation = new HashSet<Beneficiario>();
            BeneficiarioIdUsuarioClienteNavigation = new HashSet<Beneficiario>();
            Cuenta = new HashSet<Cuenta>();
            Prestamos = new HashSet<Prestamos>();
            TarjetaCredito = new HashSet<TarjetaCredito>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public string Estado { get; set; }

        public ICollection<Beneficiario> BeneficiarioIdUsuarioBeneficiarioNavigation { get; set; }
        public ICollection<Beneficiario> BeneficiarioIdUsuarioClienteNavigation { get; set; }
        public ICollection<Cuenta> Cuenta { get; set; }
        public ICollection<Prestamos> Prestamos { get; set; }
        public ICollection<TarjetaCredito> TarjetaCredito { get; set; }
    }
}
