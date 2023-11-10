DateTime currentDateTime = DateTime.Now; // Obtén la fecha y hora actuales.
Console.WriteLine("La fecha y hora actuales son: " + currentDateTime);

DateTime specificDateTime = new DateTime(2023, 7, 29); // Especifica una fecha concreta.
Console.WriteLine("La fecha especificada es: " + specificDateTime);

int year = currentDateTime.Year; // Acceder a los componentes individuales.
int month = currentDateTime.Month;
int day = currentDateTime.Day;
Console.WriteLine("Año: " + year + ", Mes: " + month + ", Día: " + day);