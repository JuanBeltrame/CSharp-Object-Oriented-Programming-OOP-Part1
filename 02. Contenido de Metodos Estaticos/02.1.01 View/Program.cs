using _02._1._01_Library;
using System.Diagnostics;

/* 
Ejercicio I09 - Dibujando un triángulo equilátero - UTN Avellaneda
----------------------------------------------------------------------
English:
Create a class called "Validator" that has a static method named "Validate" with the following signature:
bool Validate(int value, int min, int max)

value: data to be validated.
min: minimum value inclusive.
max: maximum value inclusive.

Ask the user to enter 10 integers. Validate with the previously developed method that they are within the range of -100 and 100.
After the input is finished, display the minimum entered value, maximum entered value, and the average.

Important:
Use variables, not vectors or arrays.

Spanish: 
Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.

Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

Importan: 
Utilizar variables escalares, NO utilizar vectores/arrays.

----------------------------------------------------------------------
*/

//--Programa Principal---
Console.Title = "Ejercicio I01 - Validador de rangos - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

string numero;
int min = int.MaxValue;
int max = 0;
int contador = 0;
int sumador = 0;
decimal prom;

while (contador < 2)
{
    do
    {
        Console.Write($"Ingresar un numero [{contador + 1}/10]: ");
        numero = Console.ReadLine()!;

    } while (!Validador.Validar(numero, -100, 100));
    contador++;

    sumador += int.Parse(numero);

    if (int.Parse(numero) < min)
    {
        min = int.Parse(numero);
    }
    else if (int.Parse(numero) > max)
    {
        max = int.Parse(numero);
    }
}
prom = (decimal)sumador / contador;
Console.WriteLine($"El numero de valor mas chico ingresado es: {min}");
Console.WriteLine($"El numero de valor mas grande ingresado es: {max}");
Console.WriteLine($"El Promedio de los numeros ingresados es: {prom}");
Console.ReadKey();

