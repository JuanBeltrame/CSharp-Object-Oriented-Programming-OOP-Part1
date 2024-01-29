namespace Billetes
{
    public class Peso
    {
        // Generamos los atributos para Peso
        private double cantidad;
        private static double cotizRespectoDolar;

        // Generamos los cronstructores de Dolar
        static Peso()
        {
            cotizRespectoDolar = 180;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion)
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

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
    }
}
