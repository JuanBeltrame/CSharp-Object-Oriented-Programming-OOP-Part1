using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading_Examples
{
    internal class Auto
    {
        public string patente;
        public Colores? color;
        public int dniDuenio;



        private Auto()
        {
            this.color = Colores.SinInformacion;     
        }

        public Auto(string patente, int dniDue):this()
        {
            this.patente = patente;
            dniDuenio = dniDue;
        }

        public Auto(string patIngresada, Colores color, int dniDuenio):this(patIngresada, dniDuenio)
        {
            this.color = color;
        }

        public string DevolverInformacion()
        {
            return "Info del auto";
        }

        public string DevolverInformacion(int dni)
        {
            return "dni del dueno " + dni.ToString();
        }


        
    }
}
