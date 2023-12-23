/* 
----------------------------------------------------------------------
English:
Enter a number and display the square and the cube of the number. 
You must validate that the number is greater than zero, 
otherwise, display the message: "ERROR. Re-enter number!".

Spanish: 
Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, 
caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
----------------------------------------------------------------------
*/

//------------Programa Principal-------------
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


double number;
char desicion;
char desicionInicial = 'S';
while (desicionInicial != 'N')
{

    Console.Write("Ingresar un numero: ");
    while (!double.TryParse(Console.ReadLine(), out number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error, se ingreso un caracter que no es un numero. Intente nuevamente");
        Console.Write("Ingresar un numero: ");

    }

    while (number <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("Error, el numero debe ser mayor a cero. Intente nuevamente");
        Console.Write("Ingresar un numero: ");
        double.TryParse(Console.ReadLine(), out number);
    }

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"{number} elevado al cuadrado es: " + Math.Pow(number, 2));
    Console.WriteLine($"{number} elevado al cubo es: " + Math.Pow(number, 3));

    do
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Desea Ingresar otro numero? [S/N]: ");
    } while (!char.TryParse(Console.ReadLine(), out desicion));
    desicionInicial = desicion;

}

Console.WriteLine("Gracias por haber usado el servicio.");
Console.ReadKey();

