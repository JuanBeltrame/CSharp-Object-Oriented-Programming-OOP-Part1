using System.Linq.Expressions;

int valor01;
int valor02;
int valor03;
int tamanio = 4;
byte[] valor04 = new byte[tamanio];
double valor05 = 0;
float valor06 = 0;

// Opcion, trabajar dentro de un metodo
int GenerarNumero()
{
    Random random = new Random();

    return random.Next();
}

int GetAnotherRandomNumber()
{
    Random random = new Random();

    return random.Next(1000);
}


void ByteRandomNumber(byte[] valorCuatro)
{
    Random random = new Random();
    random.NextBytes(valorCuatro);
    for (int i = 0; i < tamanio; i++)
    {
        Console.WriteLine(valorCuatro[i]);
    }
}

void GetRandomDouble(ref double valorCinco)
{
    Random random1 = new Random();
    valorCinco = random1.NextDouble();
}

void GetRandomFloat(ref float valorSeis)
{
    Random random1 = new Random();
    valorSeis = random1.NextSingle();
}


//------------Programa Principal------------

// Trabajar con Random dentro del programa principal
Random random = new Random();
valor02 = random.Next(1, 100);
Console.WriteLine(valor02);

valor01 = GenerarNumero();
Console.WriteLine(valor01);

valor03 = GetAnotherRandomNumber();
Console.WriteLine(valor03);

ByteRandomNumber(valor04);

GetRandomDouble(ref valor05);
Console.WriteLine(valor05);

GetRandomFloat(ref valor06);
Console.WriteLine(valor06);