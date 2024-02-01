using System.Text;

namespace _04._1._04_Library
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }

        public static string MostrarProducto(Producto p)
        { 
            return $"El codigo de barra del producto es: {p.codigoDeBarra}, la marca es: {p.marca}, y el precio es: {p.precio}" ;
        }

        public static bool operator ==(Producto a, Producto b)
        {
            return a.marca == b.marca && a.codigoDeBarra == b.codigoDeBarra;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }


    }
}
