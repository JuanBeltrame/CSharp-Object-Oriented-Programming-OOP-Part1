namespace Billetes
{
    internal class Peso
    {
        // Generamos los atributos para Peso
        private double cantidad;
        private static double cotizRespectoDolar;

        // Generamos los cronstructores de Peso
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
            Peso.cotizRespectoDolar = cotizacion;
        }

        // Debemos generar los metodos GET, pero en esta ocasion los vamos a remplazar por propiedades

        public double GetCantidad
        {
            get
            {
                return this.cantidad;
            }
        }
        public static double GetCotizacion
        {
            get
            {
                return Peso.cotizRespectoDolar;
            }
        }

        // Generamos la sobrecarga de Double de forma implicita 

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        // Generamos las sobrecargas explicitas para Dolar y Euro
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.GetCantidad / Peso.GetCotizacion));
        }
        
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p); // De esta manera re utilizamos las conversiones explicitas, tomamos el peso, lo convertimos a dolar y el resultado de este a Euro
        }
    }
}
