object nombre = "Juan";
int longitud = ((string)nombre).Length;

Console.WriteLine("{0} tiene {1} caracteres", nombre, longitud);


// Creación de objetos de diferentes tipos
int numero = 42;
string texto = "Hola, mundo";
int otroNumero = 100;

// Comparación de tipos
bool sonDelMismoTipo1 = numero.GetType() == texto.GetType();
bool sonDelMismoTipo2 = numero.GetType() == otroNumero.GetType();

// Salida de los resultados
Console.WriteLine("numero y texto son del mismo tipo: " + sonDelMismoTipo1); // False
Console.WriteLine("numero y otroNumero son del mismo tipo: " + sonDelMismoTipo2); // True