namespace Library_Example_02._0._06
{
    public static class StringExtendido
    {
        public static int ContarPalabras(this string str)
        {
            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int ContarPalabras(this string str, int incremento)
        {
            return str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length * incremento;
        }

        public static int ContarCaracteres(this string texto, char caracter)
        {
            return ContarCaracteres(texto, new char[] { caracter });
        }

        private static int ContarCaracteres(this string texto, char[] caracteres)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;

            texto = texto.ToLower();

            int contador = 0;

            foreach (char caracter in texto)
            {
                if (caracteres.Contains(caracter))
                {
                    contador++;
                }
            }

            return contador;
        }
    }
}
