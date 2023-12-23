using Method_Overloading_Examples;

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