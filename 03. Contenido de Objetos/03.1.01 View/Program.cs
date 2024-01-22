using _03._1._01_Library;

Console.Title = "Creo que necesito un Prestamo";
Console.ForegroundColor = ConsoleColor.Yellow;

Cuenta cuentaCliente = new Cuenta("Juan Beltrame", 0);

Console.WriteLine();
Console.WriteLine("------------------------------------------");
Console.WriteLine($"Bienvenido {cuentaCliente.GetTitular()}");
Console.WriteLine("------------------------------------------");
Console.WriteLine();


Console.WriteLine("Seleccionar Operacion a realizar: [D-Deposito / E-Extraccion]");
Console.Write("Desea ingresar dinero a la cuenta: [S/N]");
do
{

} while();
decimal ingresarDinero = decimal.Parse(Console.ReadLine()!);
cuentaCliente.Ingresar(ingresarDinero);
Console.WriteLine(cuentaCliente.Mostrar());
