using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_Operators_Conversion_Examples
{
    internal class Tiempo
    {
        public int hora;
        public int minutos;
        public int segundos;
        public string formato;

        public Tiempo() : this(0, 0, 0)
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

        public static bool operator ==(Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minutos == t2.minutos && t1.segundos == t2.segundos;
        }
        public static bool operator !=(Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tiempo t)
        {
            return (((t.hora * 60) + t.minutos) * 60) + t.segundos;
        }

        public static explicit operator Tiempo(string t)
        {
            string[] tiempoStr = t.Split(':');
            return new Tiempo(int.Parse(tiempoStr[0]), int.Parse(tiempoStr[1]), int.Parse(tiempoStr[2]));
        }

    }
}
