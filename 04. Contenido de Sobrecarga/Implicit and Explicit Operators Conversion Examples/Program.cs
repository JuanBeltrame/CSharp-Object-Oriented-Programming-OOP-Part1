using Implicit_and_Explicit_Operators_Conversion_Examples;

//---Ejemplo 01----
Tiempo t1 = new Tiempo(21, 45, 59);
Tiempo t2 = new Tiempo(21, 45, 59);
Tiempo t3 = new Tiempo(12, 20, 17);

int segundos = t1;
Console.WriteLine(segundos);

Tiempo tiempo = (Tiempo)"12:45:20";
Console.WriteLine($"Hkora {tiempo.hora} minutos: {tiempo.minutos} segundos: {tiempo.segundos}");

//---Ejemplo 02----
Persona persona = new Persona("Lautaro", DateTime.Now, 12343432);

long dni = persona;

string nombre = (string)persona;
