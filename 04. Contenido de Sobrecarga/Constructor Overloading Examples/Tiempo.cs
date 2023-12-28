using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading_Examples
{
    internal class Tiempo
    {
        int hora;
        int minutos;
        int segundos;
        string formato;

        public Tiempo() :this(0, 0,0)
        {

        }

        public Tiempo(int hora, int minutos, string formato) 
            : this(hora, minutos, 0)
        {
            this.formato = formato;
        }

        public Tiempo(int hora, int minutos, int segundos)
        {
            this.hora = hora;
            this.minutos = minutos;
            this.segundos = segundos;
        }
    }
}
