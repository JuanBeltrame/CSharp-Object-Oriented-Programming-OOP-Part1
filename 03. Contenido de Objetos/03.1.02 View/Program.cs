/* 
Ejercicio I02 - ¿Vos cuántas primaveras tenés? - UTN Avellaneda
----------------------------------------------------------------------
English:


Spanish: 
Crear una aplicación de consola y una biblioteca de clases que contenga la clase "Persona".

Deberá tener los atributos:
nombre,
fechaDeNacimiento,
dni,

Deberá tener un "constructor" que inicialice todos los atributos.

Construir los siguientes métodos para la clase:
    
. Setters y getters, para cada uno de los atributos.
. CalcularEdad(), será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
. Mostrar(), retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
. EsMayorDeEdad(), si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.

Instanciar 3 objetos de tipo Persona en el método Main.

Mostrar quiénes son mayores de edad y quiénes no.
----------------------------------------------------------------------
*/

//-----Programa Principal-----
using _03._1._02_Library;


Persona persona01 = new Persona("Juan Beltrame.", new DateTime(1987, 5, 30), 32713684);
Persona persona02 = new Persona("Ariel Betrame.", new DateTime(1991, 5, 30), 31713684);
Persona persona03 = new Persona("Olivia Beltrame.", new DateTime(2005, 5, 30), 30713684);

Console.WriteLine(persona01.Mostrar());
//Console.WriteLine(persona01.EsMayorDeEdad());





