using System.Text;

namespace _03._1._03_Library
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private decimal GetPromedio()
        {
            decimal promedio = default;

            promedio = (notaSegundoParcial + notaSegundoParcial) / 2;

            return promedio;
        }

        public int CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                int notaFinal = random.Next(6, 11);
                return notaFinal;
            }
            else
            {
                return -1;
            }
        }

        public string GetNombre()
        {
            return nombre;
        }

        public StringBuilder MostrarDatos()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre: {nombre} Apellido: {apellido}, Legajo: {legajo}");
            sb.AppendLine($"1er Parcial: {notaPrimerParcial}, 2do Parcial {notaSegundoParcial}");
            sb.AppendLine($"El promedio es: {GetPromedio()}");
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine($"La nota del examen final es: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb;
        }

    }
}
