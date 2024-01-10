/* 
Ejercicio I02 - ¿Desea continuar? - UTN Avellaneda
----------------------------------------------------------------------
English:
Sum integer numbers until the user determines to stop with a "Do you want to continue (Y/N)" message
Create the Validator class and the static method ValidateResponse, which will validate the answer input.
The method will return a boolean value, TRUE if a 'Y' was entered and FALSE if any other value was entered.


Spanish: 
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

----------------------------------------------------------------------
*/

//--Programa Principal---
using _02._1._02_Library;
using System.Globalization;

Console.Title = "Ejercicio I02 - ¿Desea continuar? - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

string? input = default;
Nullable<int> numero = default;
int? sumador = 0;

do
{
    Console.Write("Ingresar un numero para sumar: ");
    numero = int.Parse(Console.ReadLine()!);
    sumador += numero;

    Console.Write("Do you want to continue (y/n): ");
    input = Console.ReadLine()!;


    while (!Validador.ValidateResponse(input!))
    {
        Console.WriteLine("El dato ingresado no es un caracter, intentar nuevamente.");
        Console.Write("Do you want to continue (y/n): ");
        input = Console.ReadLine()!;
    }
} while (input != "n");

Console.WriteLine($"La suma de los numeros ingresados es: {sumador}");
Console.WriteLine("Thanks for using this software");





