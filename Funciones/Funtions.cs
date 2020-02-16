using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invertir_Numero_de_Dos_Cifras___Ejercicio_1.Funciones
{
    public class Funtions
    {
        public static string InvertirCifras(int numero)
        {
            string Num = "";
            for (int i = 1; i >= 0; i--)
            {
                Num += numero.ToString()[i];
            }
            return Num;
        }
    }
}
