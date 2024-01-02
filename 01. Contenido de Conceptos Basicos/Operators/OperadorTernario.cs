using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class OperadorTernario
    {
        public static void UsarOperadorTernario()
        {
            static string ExecuteFunction()
            {
                Console.WriteLine("El usuario es mayor de edad");
                return "C";
            }


            //-------------Programa Principal--------

            //-------------Usando un condicional trandicional-------------
            int mayoriaEdad01 = 18;
            int edadActual01 = 16;
            string resultado01;

            if (mayoriaEdad01 <= edadActual01)
            {
                resultado01 = "El usuario es mayor de edad";
            }
            else
            {
                resultado01 = "El usuario es menor de edad";
            }

            Console.WriteLine(resultado01);


            //-------------Utilizando Operador ternario-------------
            int mayoriaEdad02 = 18;
            int edadActual02 = 16;
            string resultado02 = default!;

            resultado02 = mayoriaEdad02 <= edadActual02 ? "El usuario es mayor de edad " : "El usuario es menor de edad";
            Console.WriteLine(resultado02);
            Console.ReadKey();

            //-------------Introduciendo Metodos en el Operador ternario-------------
            int mayoriaEdad03 = 18;
            int edadActual03 = 16;
            string resultado03;

            resultado03 = mayoriaEdad03 <= edadActual03 ? ExecuteFunction() : "El usuario es menor de edad";
            Console.WriteLine(resultado02);
            Console.ReadKey();

            //-------------Operador ternario anidado-------------
            int mayoriaEdad04 = 18;
            int edadActual04 = 25;
            string resultado04 = string.Empty;
            int votar = 21;
            int conducir = 25;

            resultado04 = conducir <= edadActual04 ? "Puede conducir y votar" :
                                    votar <= edadActual04 ? "Puede Votar" :
                                        mayoriaEdad04 <= edadActual04 ? "Es mayor de edad" : "No puede hacer nada";

            Console.WriteLine(resultado04);
        }
    }
}
