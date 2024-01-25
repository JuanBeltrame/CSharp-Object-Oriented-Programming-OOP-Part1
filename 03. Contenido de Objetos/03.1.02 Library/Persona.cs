using System;
using System.Text;

namespace _03._1._02_Library
{
    public class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento.Date;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetBirthDay()
        {
            
            return fechaDeNacimiento;
        }
        public void SetBirthDay(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public int GetDni()
        {
            return dni;
        }
        public void SetDNI(int dni)
        {
            this.dni = dni;
        }


        private int CalcularEdad()
        {
            DateTime diaActual = DateTime.Today;
            int anioActual = diaActual.Year;
            int anioNacimiento = fechaDeNacimiento.Year;
            int edad = anioActual - anioNacimiento;

            return edad;
        }
        public StringBuilder Mostrar()
        {
            StringBuilder sb = new();
            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Fecha de Nacimiento: " + fechaDeNacimiento.Date.ToString());
            sb.AppendLine("dni: " + dni.ToString());
            sb.AppendLine("Edad: " + CalcularEdad());

            return sb;
        }

        public string EsMayorDeEdad()
        {
            var edad = CalcularEdad();
            
            if (edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }
    }
}
