namespace _02._1._05_Library
{
    public class Calculadora
    {
        public static decimal Calcular(decimal operando1, decimal operando2, string tipoOperacion)
        {
            decimal resultado = default;
            switch (tipoOperacion)
            {
                case ("Suma"):
                    resultado = operando1 + operando2;
                    break;
                case ("Resta"):
                    resultado = operando1 - operando2;
                    break;
                case ("Multiplicacion"):
                    resultado = operando1 * operando2;
                    break;
                case ("Division"):
                    if (operando2 != 0)
                    {
                        resultado = operando1 / operando2;
                    }
                    else
                    {
                        Console.WriteLine("Error, tiene que ser != 0");
                        return -1;
                    }
                    break;
            }

            return resultado;
        }
    }
}
