using System.ComponentModel.Design;

namespace _02._1._01_Library
{
    public class Validador
    {
        public static bool Validar(string valor, int min, int max)
        {
            int temporal;

            if (int.TryParse(valor, out temporal))
            {

                if (temporal >= min && temporal <= max)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Numero fuera de Rango, intentar nuevamente: ");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es un numero entero, ingrese un numero: ");
                return false;
            }


        }
    }
}
