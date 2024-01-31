using _04._1._01_Library;

/* 
Ejercicio I01 - Sumador (Ej.19) - UTN Avellaneda
----------------------------------------------------------------------
English:


Spanish: 
Crear un proyecto de tipo biblioteca de clases y agregar la clase Sumador.
Crear dos constructores:
. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
. Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

En el caso de Sumar(long, long) sumará los valores numéricos
En el de Sumar(string, string) concatenará las cadenas de texto.

Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

Seguido:

Generar una conversión explícita que retorne cantidadSumas.

Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.
----------------------------------------------------------------------
*/

//-----Programa Principal-----


Console.Title = "Ejercicio I01 - Sumador (Ej.19) - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

Sumador sumador01 = new Sumador();
Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"Cantidad sumas: {sumador01.GetCantidadSumas()}");
Console.WriteLine($"Cantidad sumas: {(int)sumador01}");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
string resultadoString = sumador01.Sumar("Hola", " Mundo");
Console.WriteLine($"Resultado string: {resultadoString}");
Console.WriteLine($"Cantidad sumas: {sumador01.GetCantidadSumas()}");
Console.WriteLine($"Cantidad sumas: {(int)sumador01}");
Console.WriteLine("-----------------------------------------------");
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
long resultadoLong = sumador01.Sumar(15L, 20L);
Console.WriteLine($"Resultado Long: {resultadoLong}");
Console.WriteLine($"Cantidad sumas: {sumador01.GetCantidadSumas()}");
Console.WriteLine($"Cantidad sumas: {(int)sumador01}");
Console.WriteLine("-----------------------------------------------");

Sumador sumador02 = new Sumador(1);
Console.WriteLine();
Console.WriteLine("-----------------------------------------------");
long resultadoLong2 = sumador02.Sumar(15L, 20L);
Console.WriteLine($"Resultado Long: {resultadoLong2}");
Console.WriteLine($"Cantidad sumas: {(int)sumador02}");
Console.WriteLine("-----------------------------------------------");

Console.WriteLine($"Suma de Sumadores: {sumador01 + sumador02}");

Console.WriteLine($"Tienen la misma cantidad de sumas?: {sumador01 - sumador02}");
