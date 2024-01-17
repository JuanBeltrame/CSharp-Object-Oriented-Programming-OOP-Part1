using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _03._1._01_Library
{
    public class Cuenta
    {
        string titular;
        decimal cantidad;

        public Cuenta()
        {
            
        }

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {
            return cantidad;
        }

        public StringBuilder Mostrar()
        {
            StringBuilder sb = new();

            sb.AppendLine($"El titual de la cuenta es: {titular}");
            sb.AppendLine($"El saldo de la cuenta es: {cantidad}");

            return sb;
        }

        public void Ingresar(decimal cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = cantidad;
            }
            else
            {

            }
        }

        public void Retirar(decimal monto)
        {
            cantidad = -monto;
        }
    }
}
