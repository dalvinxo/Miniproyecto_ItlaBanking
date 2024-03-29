﻿using ItlaBanking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItlaBanking.ViewModels
{
    public class PagosViewModel
    {
        //public int IdUsuario;

        [Required(ErrorMessage = "El numero de cuenta no debe estar vacio")]
        public int? NumeroCuenta { get; set; }

    
        [RegularExpression("([0-9]+)", ErrorMessage = "Por favor agregar numeros validos")]
        [Range(100000000, 999999999, ErrorMessage = "la cantidad de numeros para numero de cuenta debe ser 9 digitos")]
        [Required(ErrorMessage = "Debes Enviar un numero de cuenta.")]
        public int? NumeroCuentaPagar { get; set; }


        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})?$", ErrorMessage = "Por favor agregar numeros validos")]
        [Range(0, 99999999999.99, ErrorMessage = "la cantidad de dinero no pueder ser mayor a ser 13 digitos")]
        [Required(ErrorMessage = "El monto no debe estar vacio.")]
        public decimal? Monto { get; set; }

        public int TipoTransaccion { get; set; }

        public IEnumerable<Prestamos> prestamos;

        public IEnumerable<Cuenta> cuenta;

        public IEnumerable<TarjetaCredito> tarjetas;


    }


}
