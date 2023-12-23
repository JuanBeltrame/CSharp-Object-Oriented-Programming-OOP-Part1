//------------Programa Principal------------------
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
Console.Write("Ingresar un numero: ");
while(!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Error, se ingreso un caracter que no es un numero. Intente nuevamente");
    Console.Write("Ingresar un numero: ");
}


Console.ReadKey();