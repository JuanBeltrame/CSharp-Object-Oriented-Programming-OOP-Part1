using _03._1._01_Library;

Cuenta cuentaCliente = new Cuenta("Juan Beltrame", 0);

static void MostrarPantalla()
{
    Console.WriteLine("Seleccionar Operacion a realizar:");
    Console.WriteLine("D - Deposito: ");
    Console.WriteLine("E - Extraccion: ");
    Console.WriteLine("S - Salir: ");
}

void Menu(char opcion)
{
    switch (opcion)
    {
        case 'D':
            Console.WriteLine("");
            Console.WriteLine("Ingresar monto a depositar: ");
            decimal ingresarDinero = decimal.Parse(Console.ReadLine()!);
            cuentaCliente.Ingresar(ingresarDinero);
            Console.WriteLine(cuentaCliente.Mostrar());
            break;
        case 'E':
            Console.WriteLine("Ingresar monto a Extraer: ");
            decimal retirarDinero = decimal.Parse(Console.ReadLine()!);
            cuentaCliente.Retirar(retirarDinero);
            Console.WriteLine(cuentaCliente.Mostrar());
            break;
    }
}

//---------Programa Principal----------
Console.Title = "Creo que necesito un Prestamo";
Console.ForegroundColor = ConsoleColor.Yellow;

char op = default;


Console.WriteLine();
Console.WriteLine("------------------------------------------");
Console.WriteLine($"Bienvenido {cuentaCliente.GetTitular()}");
Console.WriteLine("------------------------------------------");
Console.WriteLine();


do
{
    do
    {
        MostrarPantalla();
        char.TryParse(Console.ReadLine(), out op);
    } while (Cuenta.ValidarChar(op));
    Menu(op);
} while (op != 'S');







