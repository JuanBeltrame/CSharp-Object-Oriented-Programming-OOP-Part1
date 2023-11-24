namespace Library_Example_02._0._05
{
    public class Validadora
    {

        private static List<string> historialPalabrasValidadas;

        static Validadora()
        {
            historialPalabrasValidadas = new List<string>();
        }

        public static bool ValidarString(string dato, int longitudMinima)
        {
            historialPalabrasValidadas.Add(dato);

            if (string.IsNullOrEmpty(dato))
            {
                return false;
            }

            if (dato.Length <= longitudMinima)
            {
                return false;
            }

            return true;
        }
    }
}
