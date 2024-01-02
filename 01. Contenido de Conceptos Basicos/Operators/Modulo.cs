using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Modulo
    {
        public static void USarModuloOperatorExample01()
        {
            // Modulo %

            int num1 = 10;
            int num2 = 5;

            int remainder = num1 % num2;

            Console.WriteLine("Remainder: " + remainder);


        }
        public static void USarModuloOperatorExample02()
        {
            // Modulo %

            int num1 = 11;
            int num2 = 5;

            int remainder = num1 % num2;

            Console.WriteLine("Remainder: " + remainder);
        }

        public static bool EvenOrOdd()
        {
            // Modulo %

            int num1 = 10;
            
            if(num1 % 2 == 0)
            {
                // Even
            }
            else
            {
                // Odd
            }
            
            // Si un numero es divisible por 3, en este caso. 

            int num2 = 9;
            
            if(num1 % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

    }
}
