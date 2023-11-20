using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Example_03._0._02
{
    internal class Usuario
    {
        public string nombre;
        private string contrasenia;


        public Usuario(string nombre, string constrasenia)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
            else
            {
                this.nombre = "Sin nombre";
            }

            this.contrasenia = constrasenia;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public bool ComprobarPass(string pass)
        {
            return contrasenia == pass;
        }

        public void ModificarContra(string pass)
        {
            this.contrasenia = pass;
        }
    }
}
