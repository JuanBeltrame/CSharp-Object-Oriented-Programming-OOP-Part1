using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_03._0._05
{
    internal class Automovil
    {
        public string patente;
        public int anio;
        public bool estaEncendido;
        public bool tienePuertasCerradas;


        public Automovil(string patente, int anio)
        {
            this.patente = patente;
            this.anio = anio;
        }

        public void Encender()
        {
            estaEncendido = true;
        }

        public void TrabarPuertas()
        {
            tienePuertasCerradas = true;
        }
    }
}
