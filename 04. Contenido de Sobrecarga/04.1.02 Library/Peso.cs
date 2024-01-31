namespace Billetes
{
    public class Peso
    {
        // Generamos los atributos para Peso
        private double cantidad;
        private static double cotizRespectoDolar;

        // Generamos los cronstructores de Peso
        static Peso()
        {
            Peso.cotizRespectoDolar = 1/66;
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

        public double GetC()
        {
            return this.cantidad;
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

        // Generamos las sobrecargas para los comparadores y operadores aritmeticos
        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.GetCantidad == p2.GetCantidad);
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.GetCantidad == ((Peso)d).GetCantidad);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return (p.GetCantidad == ((Peso)d).GetCantidad);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p.GetCantidad == ((Peso)e).GetCantidad);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator -(Peso p, Euro d)
        {
            return new Peso(p.GetCantidad - ((Peso)d).GetCantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad - ((Peso)d).GetCantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad + ((Peso)e).GetCantidad);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad + ((Peso)d).GetCantidad);
        }

    }
}
