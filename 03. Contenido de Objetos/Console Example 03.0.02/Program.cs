using Console_Example_03._0._02;

Usuario usuarioCaro = new Usuario("Caruchi", "JuanaJuana123");
Usuario usuarioLauti = new Usuario("Lauti", "SuperPro123");

// Opcion 1
if (usuarioCaro.ComprobarPass("pepepepe"))
{
    Console.WriteLine("Caro Logueada");
}
else
{
    Console.WriteLine("Raja de aca");
}

// Opcion 2
if (usuarioCaro.ComprobarPass("JuanaJuana123"))
{
    Console.WriteLine($"{usuarioCaro.GetNombre()} logeada");
}
