using _02._1._04_Library;

/* 
Ejercicio I06 - Calculadora de áreas - UTN Avellaneda
----------------------------------------------------------------------
English:
Make a class called AreaCalculator that has three (static) class methods that perform the calculation of the corresponding area:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

Data entry and visualization should be done from the Main() method.


Spanish: 
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().

----------------------------------------------------------------------
*/

//--Programa Principal---

Console.Title = "Ejercicio I06 - Calculadora de áreas - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;


// Invoco al metodo estatico CalculoCuadrado() a traves de la clase
Console.WriteLine("Area de un cuadrado de lado 5: " + CalculoDeArea.CalculoCuadrado(5));

Console.WriteLine("Area de un triangulo de base 2 y altura 3: " + CalculoDeArea.CalculoTriangulo(2, 3));

Console.WriteLine("Area de un circulo de radio 3: " + CalculoDeArea.CalculoCirculo(3));