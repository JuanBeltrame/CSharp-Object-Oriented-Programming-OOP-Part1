using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Examples
{
    internal class Sobrecargadora
    {
        // Sobrecarga con distinta cantidad de parametros
        public static int Sumar(int operando01, int operando02)
        {
            return operando01 + operando02;
        }

        public static int Sumar(int operando01, int operando02, int operando03)
        {
            return operando01 + operando02 + operando03;
        }

        public static string Concatenar(string cadena01, string cadena02)
        {
            return $"Esta es la primer cadena {cadena01} y esta es la segunda {cadena02}";
        }

        public static string Concatenar(string cadena01, string cadena02, int numero)
        {
            return $"Esta es la primer cadena {cadena01} y esta es la segunda {cadena02}, le agregamos un numero {numero}";
        }

        


    }
}
