using Library_Example_02._0._01;
using Library_Example_02._0._02;
using Formulas = Library_Example_02._0._03.Formulas;
using Formulas2 = Library_Example_02._0._04.Formulas;
using Library_Example_02._0._05;


// Library Example 02.0.01
void LibraryExample02001()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Library Example 02.0.01: Cotizador");
    decimal valorObetidoEnDolares = Cotizador.CotizadorCompraDolares(100);
    decimal valorObtenidoEnPesos = Cotizador.CotizarVentaDolares(100);
    Console.WriteLine("Valor obtenido en Dolares {0}", valorObetidoEnDolares);
    Console.WriteLine("Valor obtenido en Pesos {0}", valorObtenidoEnPesos);
}

// Library Example 02.0.02
void LibraryExample02002()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Library Example 02.0.02: ConversorDeTemperatura");
    MostrarTemperaturas();
}
static void MostrarTemperaturas()
{
    Console.WriteLine("Temperatura Celsius: {0}", ConversorDeTemperatura.ConvertirCelciusAKelvin(300));
    Console.WriteLine("Temperatura Kelvin: {0}", ConversorDeTemperatura.ConvertirKelvinACelciud(200));
}

// Library Example 02.0.03 and // Library Example 02.0.4
void LibraryExample0200304()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Library Example 02.0.03 & Library Example 02.0.04");
    string nm1 = Formulas.DevolverMensaje();
    string nm2 = Formulas2.DevolverMensaje();
    Console.WriteLine(nm1);
    Console.WriteLine(nm2);
}

// Library Example 02.0.05
void LibraryExample02005()
{
    
    Console.ForegroundColor = ConsoleColor.DarkRed;
    string patenteIngresada = Console.ReadLine()!;
    bool datoEsValido = Validadora.ValidarString(patenteIngresada, 6);

    while (!datoEsValido)
    {
        Console.WriteLine("Reingresar Patente");
        patenteIngresada = Console.ReadLine()!;
        datoEsValido = Validadora.ValidarString(patenteIngresada, 6);
    }
    Console.WriteLine("");

    Console.WriteLine(patenteIngresada);
    string nombreDuenio = Console.ReadLine()!;
    datoEsValido = Validadora.ValidarString(nombreDuenio, 3);

    while (!datoEsValido)
    {
        Console.WriteLine("Reingresar Patente");
        patenteIngresada = Console.ReadLine()!;
        datoEsValido = Validadora.ValidarString(patenteIngresada, 6);
    }
    Console.WriteLine(nombreDuenio);

}



// Programa Principal
LibraryExample02001();
Console.WriteLine("");

LibraryExample02002();
Console.WriteLine("");

LibraryExample0200304();
Console.WriteLine("");

LibraryExample02005();