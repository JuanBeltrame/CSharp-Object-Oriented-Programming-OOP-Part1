namespace _02._1._04_Library
{
    // Clase estatica
    public static class CalculoDeArea
    {
        // Metodo estatico
        public static double CalculoCuadrado(double lado)
        {
            // Utilizo metodo estatico para calcular la potencia
            return Math.Pow(lado, 2);
        }

        public static double CalculoTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalculoCirculo(double radio)
        {
            // Utilizo la constante PI de la calse Math
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
