using Library_Example_02._0._06;
using static System.Console;

string texto = "Hola Mundo";
int cantidadDePalabras = texto.ContarPalabras();

WriteLine($"{texto} tiene {cantidadDePalabras} de palabras");

string texto2 = "Hola Metodo estatico";
int cantidadDePalabras2 = StringExtendido.ContarPalabras(texto2);

WriteLine(texto2 + " tiene " + cantidadDePalabras2 + " palabras");

string text003 = "Hola Mundo";
int cantidadDePalabras3 = text003.ContarPalabras(2);

WriteLine($"{text003} tiene {cantidadDePalabras3} palabras");

