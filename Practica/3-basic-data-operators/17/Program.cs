using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		Escriba un programa de C# que tome la distancia (metros) y el tiempo como entrada y muestre la velocidad en kilómetros por hora y millas por hora. Ir al editor
    Datos de prueba:
    Distancia de entrada (metros): 50000
    Tiempo de entradaHoras (hora): 1
    Tiempo de entradaMinut (minutos): 35
    Tiempo de entradaSec (segundos): 56
    Resultado esperado:
    Avanzando 50000 metros en 1:35:56 iremos a 8.68658790826963 metros/segundo
    Velocidad en km/h: 31.2717164697707 km/h
    Velocidad en millas/h: 19.5448227936067 millas/h
		*/
            Console.WriteLine("Introduzca la distancia recorrida (en metros): ");
            double meters = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca las horas transcurridas:");
            byte timeHours = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduzca los minutos transcurridos:");
            byte timeMins = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Introduzca los segundos transcurridos:");
            byte timeSeconds = Convert.ToByte(Console.ReadLine());

            // Obtener metros / sg, convertir los tiempos en segundos
            ushort totalTimeSeconds = (ushort)((timeHours * 3600) + (timeMins * 60) + timeSeconds);
            double metersPerSecond = meters / totalTimeSeconds;
            Console.WriteLine($"Avanzando {meters} metros en {timeHours}:{timeMins}:{timeSeconds} iremos a {metersPerSecond} metros/segundo");

            // Sabiendo lo metros por segundo, si hacemos por 3.6, convertimos a velocidad en km/h
            double speedKmPerHour = metersPerSecond * 3.6;
            Console.WriteLine($"Velocidad en km/h: {speedKmPerHour} km/h");

            // Sabiendo la velocidad en km/h, podremos obtener las millas diviendo entre 1.66
            double speedMilesPerHour = speedKmPerHour / 1.6;
            Console.WriteLine($"Velocidad en millas/h: {speedMilesPerHour} millas/h");
        }
    }
}
