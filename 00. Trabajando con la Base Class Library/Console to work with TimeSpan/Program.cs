TimeSpan time01;

TimeSpan Metodo1conTimeSpan()
{
    TimeSpan timeSpan = new TimeSpan(-1, -30, -45); // Un TimeSpan negativo

    // Obtener la duración absoluta
    TimeSpan time = timeSpan.Duration();

    return time;
}

void Metodo2conTimeSpan()
{
    TimeSpan miTiempoSpan = new TimeSpan(1, 2, 30, 45); // 1 día, 2 horas, 30 minutos, 45 segundos
  
}

// ---------Programa Principal-----------

time01 = Metodo1conTimeSpan();
Console.WriteLine(time01);








// Crear un nuevo objeto TimeSpan
TimeSpan interval = new TimeSpan(2, 14, 18);  // 2 horas, 14 minutos, 18 segundos
Console.WriteLine(interval.ToString()); // Imprime "02:14:18"

// Obtener la diferencia entre dos objetos DateTime
DateTime start = new DateTime(2023, 1, 1);
DateTime end = new DateTime(2023, 12, 31);
TimeSpan difference = end - start;
Console.WriteLine(difference.Days); // Imprime el número de días entre start y end

// Agregar a un TimeSpan
TimeSpan addedInterval = interval.Add(new TimeSpan(1, 0, 0)); // Agrega una hora
Console.WriteLine(addedInterval.ToString()); // Imprime "03:14:18"

