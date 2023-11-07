using Library_02._0._01;

decimal valorObetidoEnDolares = Cotizador.CotizadorCompraDolares(100);

decimal valorObtenidoEnPesos = Cotizador.CotizarVentaDolares(100);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Datos Cotizaciones: ");
Console.WriteLine(valorObetidoEnDolares);
Console.WriteLine(valorObtenidoEnPesos);
