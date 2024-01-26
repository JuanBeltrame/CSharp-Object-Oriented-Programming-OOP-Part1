/* 
Ejercicio I03 - El ejemplo universal - UTN Avellaneda
----------------------------------------------------------------------
English:


Spanish: 
Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

La clase Estudiante:
. Tendrá un constructor estático que inicializará el atributo estático random.
. Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
. El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
. El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
. El método privado CalcularPromedio retornará el promedio de las dos notas.

. El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos 
  siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, 
  caso contrario la inicializará con el valor -1.

. El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
    Nombre, apellido y legajo.
    Nota del primer y segundo parcial.
    Promedio.
    Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

1. Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
2. Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
3. Mostrar los datos de todos los alumnos.

IMPORTANTE
Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.
----------------------------------------------------------------------
*/

//-----Programa Principal-----
using _03._1._03_Library;
using System;

Console.Title = "Ejercicio I03 - El ejemplo universal - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

Estudiante estudiante01 = new Estudiante("Juan", "Beltrame", "46084");
Estudiante estudiante02 = new Estudiante("Ariel", "Beltrame", "46085");
Estudiante estudiante03 = new Estudiante("Olivia", "Beltrame", "46086");
List<Estudiante> listaDeEstudiantes = new() { estudiante01, estudiante02, estudiante03 };

Console.WriteLine("-------------------------------");
foreach(var estudiante in listaDeEstudiantes)
{
    int index = 0;
    Console.WriteLine($"Alumno: {estudiante.GetNombre()}");
    Console.Write($"Ingresar nota del Parcial {++index}: " );
    int.TryParse(Console.ReadLine(), out int nota1);
    estudiante.SetNotaPrimerParcial(nota1);
    Console.Write($"Ingresar nota del Parcial {++index}: ");
    int.TryParse(Console.ReadLine(), out int nota2);
    estudiante.SetNotaSegundoParcial(nota2);
}
Console.WriteLine(  );
Console.WriteLine("-------------------------------");
foreach (Estudiante estudiante in listaDeEstudiantes)
{
    Console.WriteLine(  );
    Console.WriteLine(estudiante.MostrarDatos());
    Console.WriteLine(  );
}
Console.WriteLine("-------------------------------");





