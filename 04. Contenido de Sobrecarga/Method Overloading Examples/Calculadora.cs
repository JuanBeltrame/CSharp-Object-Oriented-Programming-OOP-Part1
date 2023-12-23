using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Examples
{
    internal class Calculadora
    {
        // Sobrecarga con distinta cantidad de parametros
        public static int Sumar(int operando01, int operando02, int operando03, int operando04)
        {
            return operando01 + operando02 + operando03 + operando04;
        }

        public static int Sumar(int operando01, int operando02)
        {
            return Sumar(operando01, operando02, 0, 0);
        }

        // Sobrecarga con distinto tipo de parametros
        public static float Sumar(float operando01, float operando02, float operando03, float operando04)
        {
            return operando01 + operando02 + operando03 + operando04;
        }

        // Sobrecarga con distinto orden de parametros
        public static int Sumar(int operando01, string operando02)
        {
            return Sumar(operando01, int.Parse(operando02));
        }

        public static void Sumar(ref string mensaje, int operando01)
        {
            mensaje = operando01.ToString() + mensaje;
        }

    }
}
