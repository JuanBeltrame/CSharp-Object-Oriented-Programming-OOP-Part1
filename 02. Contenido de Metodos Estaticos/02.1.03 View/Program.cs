/* 
Ejercicio I03 - Conversor binario - UTN Avellaneda
----------------------------------------------------------------------
English:
Create a class called Converter that has two (static) class methods:

The method "ConvertDecimalToBinary" that converts an integer from the decimal system to the binary system.
public string ConvertDecimalToBinary(int integerNumber) {}

The "ConvertBinaryToDecimal" method that converts an integer from the binary system to the decimal system.
public int ConvertBinaryToDecimal(int integerNumber) {}

Do NOT use the language shortcuts, do it using iteration and selection structures.


Spanish: 
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.
public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
public int ConvertirBinarioADecimal(int numeroEntero) {}

NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
----------------------------------------------------------------------
*/

//--Programa Principal---

using _02._1._03_Library;

int ingresoDecimal;
string ingresoBinario;
string binario;
int numeroDecimal;

Console.WriteLine("Ingrese el numero Decimal: ");
int.TryParse(Console.ReadLine(), out ingresoDecimal);
binario  = Converter.DecimalToBinary(ingresoDecimal);
Console.WriteLine($"El resultado Binario es: {binario}");

Console.WriteLine("Ingrese el numero Binario: ");
ingresoBinario = Console.ReadLine()!;
numeroDecimal = Converter.BinaryToDecimal(ingresoBinario);
Console.WriteLine($"El resultado en Decimal es: {numeroDecimal}");
Console.ReadKey();
