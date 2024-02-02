using System.Text;
using System.Text.RegularExpressions;

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

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"El codigo de barra del producto es: {p.codigoDeBarra}, la marca es: {p.marca}, y el precio es: {p.precio}";
        }

        // Sobrecarga de Operadores
        // == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
        public static bool operator ==(Producto a, Producto b)
        {
            return a.marca == b.marca && a.codigoDeBarra == b.codigoDeBarra;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        // == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        // Sobrecarga de Operadores de Conversion
        // explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }



    }
}
