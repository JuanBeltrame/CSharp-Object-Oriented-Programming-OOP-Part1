using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1._04_Library
{
    public class Estante
    {
        Producto []productos;
        int ubicacionEstante;

        private Estante(int capacidad )
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacionEstante)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos()
        {
            return productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new();
            sb.AppendLine($"Ubicacion: {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null)
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                }
            }
            return $"Ubicacion del estante: {e.ubicacionEstante} y sus Productos: {e.GetProductos()}";
        }

        // Sobrecarga de Operadores
        // ==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
        public static bool operator ==(Estante e, Producto p)
        {
            for(int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        // +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más y dicho producto no se encuentra en el estante, false caso contrario.Reutilizar código.
        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        // -: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.
        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }

            }
            return e;
        }
    }
}
