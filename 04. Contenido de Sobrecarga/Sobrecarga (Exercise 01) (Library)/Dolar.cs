using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Dolar
    {
        // Generamos los atributos para Dolar
        private double cantidad;
        private static double cotizRespectoDolar;

        // Generamos los cronstructores de Dolar
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion)
        : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        // Debemos generar los metodos GET, pero en esta ocasion los vamos a remplazar por propiedades

        public double GetCantidad
        {
            get
            {
                return cantidad;
            }
        }
        public static double GetCotizacion
        {
            get
            {
                return cotizRespectoDolar;
            }
        }

        // Generamos la sobrecarga de Double de forma implicita 

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);    
        }

        // Generamos las sobrecargas explicitas para Euro y Peso

        public static explicit operator Euro (Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion);
        }

        public static explicit operator Peso (Dolar d)
        {
            return new Peso(d.cantidad * Euro.GetCotizacion);
        }
    }
}
