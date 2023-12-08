using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_03._0._01
{
    internal class Gato
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        public Gato(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetNombreOpcion1(string nombre)
        {
            if (nombre is null)
            {
                this.nombre = "Sin nombre";
            }
            else
            {
                this.nombre = nombre;
            }
        }

        public void SetNombreOpcion2(string nombre)
        {
            nombre = " ";
            
            if (string.IsNullOrEmpty(nombre))
            {
                nombre = "Sin nombre";
            }
        }

        public void AsignarPesoOpcion1(double peso)
        {
            if (peso < 0)
            {
                peso = 0;
            }

            this.peso = peso;
        }

        public void AsignarPesoOpcion2(double nuevoPeso)
        {
            peso = nuevoPeso;
        }

        public string ObtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del Gato: ");
            sb.AppendFormat("Nombre del Gato: {0} ", nombre);

            if (nombre is not null)
            {
                sb.AppendLine($"Nombre : {nombre.ToUpper()}");
            }
            else
            {
                sb.AppendLine("Sin nombre");
            }


            // Strings Interpolados: es con el signo pesos adelante
            sb.Append($"Fecha de naciemnto: {fechaNacimiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($" Peso: {peso}");
            return sb.ToString();
            
        }

        public double GetPeso()
        {
            return peso;
        }
    }
}
