using System;

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
            this.fechaDeNacimiento = fechaDeNacimiento;
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


        private TimeSpan CalcularEdad(DateTime fechaDeNacimiento)
        {
            DateTime diaActual = DateTime.Today;
            TimeSpan edad = diaActual - fechaDeNacimiento;
            return e;
        }
    }
}
