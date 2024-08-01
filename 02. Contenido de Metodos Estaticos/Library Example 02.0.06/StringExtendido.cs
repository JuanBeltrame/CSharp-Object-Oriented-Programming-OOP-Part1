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
            if (string.IsNullOrEmpty(texto))
                return 0;

            int contador = 0;

            foreach (char caracterTexto in texto)
            {
                if (caracterTexto == caracter)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
