using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Invertir_Numero_de_Dos_Cifras___Ejercicio_1.Models
{
    public class NumeroIngresado
    {
        public int Id { get; set; }

        [Required]//Valida que no sea nulo
        [Range(10, 99)]
        public int Numero { get; set; }
    }
}
