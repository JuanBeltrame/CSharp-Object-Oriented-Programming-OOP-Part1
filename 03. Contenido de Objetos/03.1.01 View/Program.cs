using _03._1._01_Library;

/* 
Ejercicio I01 - Creo que necesito un préstamo - UTN Avellaneda
----------------------------------------------------------------------
English:


Spanish: 
Crear una aplicación de consola y una biblioteca de clases que contenga la clase "Cuenta".
Deberá tener los atributos:
.titular: Que contendrá la razón social del titular de la cuenta.
.cantidad: Que será un número decimal que representa al monto actual de dinero en la cuenta.

Construir los siguientes métodos para la clase:
. Un constructor, que permita inicializar todos los atributos.
. Un método getter, para cada atributo.
. Mostrar(), retornará una cadena de texto con todos los datos de la cuenta.
. Ingresar(), recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
. Retirar(), recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.

En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.

----------------------------------------------------------------------
*/


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
Console.Title = "Ejercicio I01 - Creo que necesito un préstamo - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;

char op = default;
char opUpper = default;


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
        opUpper = char.ToUpper(op);
    } while (Cuenta.ValidarChar(opUpper));
    Menu(opUpper);
} while (opUpper != 'S');



