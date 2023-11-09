namespace Library_Example_02._0._05
{
    public class Validadora
    {
        public static bool ValidarString(string dato, int longitudMinima)
        {
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
