using System.Text;

StringBuilder sb = new StringBuilder();

// Anexa un nuevo texto y genera un salto de línea
sb.AppendLine("Resultados");

// En AppendFormat, puedes usar formato compuesto 
int maximo = 10; // Solo para ejemplo
sb.AppendFormat($"El número máximo es {maximo}\n", maximo);

// AppendLine acepta cadenas interpoladas
int minimo = 5; // Solo para ejemplo
sb.AppendLine($"El número máximo es: {maximo} y el mínimo es: {minimo}");

// Variables para el ejemplo
int acumNumeros = 30;
int contNumeros = 3;

sb.AppendLine($"El promedio total es: {acumNumeros / contNumeros}");

// Append genera texto SIN salto de línea
sb.Append("Fin...");

Console.WriteLine(sb.ToString());
