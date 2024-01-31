using _04._1._01_Library;

/* 
Ejercicio I01 - Sumador (Ej.19) - UTN Avellaneda
----------------------------------------------------------------------
English:


Spanish: 

----------------------------------------------------------------------
*/

//-----Programa Principal-----


Console.Title = "Ejercicio I01 - Sumador (Ej.19) - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

Sumador sumador = new Sumador();
Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
Console.WriteLine($"Cantidad sumas: {(int)sumador}");

string resultadoString = sumador.Sumar("Hola", " Mundo");
Console.WriteLine($"Resultado string: {resultadoString}");
Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
Console.WriteLine($"Cantidad sumas: {(int)sumador}");

long resultadoLong = sumador.Sumar(15L, 20L);
Console.WriteLine($"Resultado Long: {resultadoLong}");
Console.WriteLine($"Cantidad sumas: {sumador.GetCantidadSumas()}");
Console.WriteLine($"Cantidad sumas: {(int)sumador}");

Sumador sumador2 = new Sumador(1);

long resultadoLong2 = sumador2.Sumar(15L, 20L);
Console.WriteLine($"Resultado Long: {resultadoLong2}");
Console.WriteLine($"Cantidad sumas: {(int)sumador2}");

Console.WriteLine($"Suma de Sumadores: {sumador + sumador2}");

Console.WriteLine($"Tienen la misma cantidad de sumas?: {sumador - sumador2}");
