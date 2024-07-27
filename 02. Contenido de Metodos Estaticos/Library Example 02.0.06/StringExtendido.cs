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
    }
}
