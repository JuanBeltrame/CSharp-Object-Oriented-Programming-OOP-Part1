int price01 = 0; // <- Value is Zero.
                 

// Opcion utilizando: ? // Viene a ser como la sintaxis corta
int? price02 = null; // <- No value at all.

if (price02 == null)
{
    Console.WriteLine(nameof(price02)+" Es null");
}
else
{

}

// Opcion utilizando: Nullable
Nullable<int> price03 = null; // <- No value at all.

if (price03 == null)
{
    Console.WriteLine(nameof(price03) + " Es null");
}