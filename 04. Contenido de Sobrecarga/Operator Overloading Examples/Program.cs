using Operator_Overloading_Examples;
//----Ejemplo 01-----
Tiempo t1 = new Tiempo(21, 45, 59);
Tiempo t2 = new Tiempo(21, 45, 59);
Tiempo t3 = new Tiempo(12, 20, 17);

Console.WriteLine(t1 == t2);
Console.WriteLine(t1 != t2);
Console.WriteLine(t1 != t3);

//----Ejemplo 02-----
Persona persona1 = new Persona();
Persona persona2 = new Persona("Juan", DateTime.Now, 33334545);
Persona persona3 = new Persona("Juan", new DateTime(1998, 5, 9));
Persona persona4 = new Persona("Ariel", new DateTime(1998, 5, 9), 32713684);

Console.WriteLine(persona1 == persona2);

Aula aula = new Aula();

aula += persona1;
aula += persona2;
aula += persona3;
aula += persona4;

