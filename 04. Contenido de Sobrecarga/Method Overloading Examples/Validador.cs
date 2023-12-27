using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Examples
{
    internal class Validador
    {
        // Sobrecarga con distinto tipo de parametros
        public static bool ValidarRango(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
        public static bool ValidarRango(float valor, float min, float max)
        {
            return valor >= min && valor <= max;
        }
        public static bool ValidarRango(string valor, float min, float max)
        {
            return valor.Length >= min && valor.Length <= max;
        }




    }
}
