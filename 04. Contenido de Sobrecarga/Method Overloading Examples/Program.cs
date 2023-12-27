using Method_Overloading_Examples;

//-----------Ejemplo 01--------------------------------
int resultado01 = Calculadora.Sumar(1, 2, 3, 4);
Console.WriteLine(resultado01);

int resultado02 = Calculadora.Sumar(1, 2);
Console.WriteLine(resultado02);

float resultado03 = Calculadora.Sumar(1.2f, 1.2f, 1.2f, 1.2f);
Console.WriteLine(resultado03);

int resultado04 = Calculadora.Sumar(1, "2");
Console.WriteLine(resultado04);

string? mensaje =default;
Calculadora.Sumar(ref mensaje!, 2);
Console.WriteLine(mensaje);

//-----------Ejemplo 02--------------------------------
int resultado05 = Sobrecargadora.Sumar(5, 8);
Console.WriteLine(resultado05);

int resultado06 = Sobrecargadora.Sumar(5, 8, 10);
Console.WriteLine(resultado06);

Console.WriteLine(Sobrecargadora.Concatenar("Hola","Mundo"));
Console.WriteLine(Sobrecargadora.Concatenar("Hola","Mundo", 12));


//-----------Ejemplo 03--------------------------------
Validador.ValidarRango(4, 0, 10);
Validador.ValidarRango(4.5f, 0.1f, 10.12f);
Validador.ValidarRango("Hola", 1, 10);