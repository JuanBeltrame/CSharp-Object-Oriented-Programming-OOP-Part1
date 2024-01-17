using _03._1._01_Library;

Console.Title = "Creo que necesito un Prestamo";
Console.ForegroundColor = ConsoleColor.Yellow;


Cuenta cuentaDeJuan = new Cuenta("Juan Beltrame", 0);

Console.Write("Ingresar dinero a la cuenta: ");
decimal ingresarDinero = decimal.Parse(Console.ReadLine()!);
cuentaDeJuan.Ingresar(ingresarDinero);
Console.WriteLine(cuentaDeJuan.Mostrar());
