using Billetes;

/* 
Ejercicio I02 - Cotizador - UTN Avellaneda
----------------------------------------------------------------------
English:


Spanish: 
Generar un nuevo proyecto del tipo Console Application. 
Construir tres clases dentro de un namespace llamado Billetes: Pesos, Euro y Dólar.

a. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí con total normalidad como si fueran tipos numéricos, 
teniendo presente que 1 Euro equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.

b. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.

c. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos tipos de datos.

d. Colocar dentro del Main el código necesario para probar todos los métodos.

e. Los constructores estáticos le darán una cotización respecto del dólar por defecto a las clases.

f. Los comparadores == compararan cantidades.

g. Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego sumarlos.

h. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.
----------------------------------------------------------------------
*/

//-----Programa Principal-----


Console.Title = "Ejercicio Numero 20 - Ejercicio I02 - Cotizador - UTN Avellaneda";
Console.ForegroundColor = ConsoleColor.Yellow;
Euro e = new Euro(10, 0.809f);
Dolar d = new Dolar(10);
Peso p = new Peso(10, 20.1655f);

Peso p2 = 10;
Peso p3 = new Peso(10);

Euro aux_e = e + d;
Console.WriteLine(@"Euro + Dólar (€18,09xx): {0}", aux_e.GetCantidad);
aux_e = e + p;
Console.WriteLine("Euro + Pesos (€10,40xx): {0}", aux_e.GetCantidad);
Console.WriteLine("----------------------------------------------");

Dolar aux_d = d + e;
Console.WriteLine("Dólar + Euro (U$S22,36xx): {0}", aux_d.GetCantidad);
aux_d = d + p;
Console.WriteLine("Dólar + Pesos (U$S10,49xx): {0}", aux_d.GetCantidad);
Console.WriteLine("----------------------------------------------");

Peso aux_p = p + e;
Console.WriteLine("Pesos + Euro ($259,26xx): {0}", aux_p.GetCantidad);
aux_p = p + d;
Console.WriteLine("Pesos + Dólar ($211,65xx): {0}", aux_p.GetCantidad);




