using Library_02._0._01;
using Library_Example_02._0._02;


// Library Example 02.0.01
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Library Example 02.0.01: Cotizador");
Console.WriteLine("");
decimal valorObetidoEnDolares = Cotizador.CotizadorCompraDolares(100);
decimal valorObtenidoEnPesos = Cotizador.CotizarVentaDolares(100);

Console.WriteLine("Valor obtenido en Dolares {0}", valorObetidoEnDolares);
Console.WriteLine("Valor obtenido en Pesos {0}", valorObtenidoEnPesos);

Console.WriteLine("");

// Library Example 02.0.02
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Library Example 02.0.02: ConversorDeTemperatura");
Console.WriteLine("");
MostrarTemperaturas();
static void MostrarTemperaturas()
{
    Console.WriteLine("Temperatura Celsius: {0}", ConversorDeTemperatura.ConvertirCelciusAKelvin(300));
    Console.WriteLine("Temperatura Kelvin: {0}", ConversorDeTemperatura.ConvertirKelvinACelciud(200));
}