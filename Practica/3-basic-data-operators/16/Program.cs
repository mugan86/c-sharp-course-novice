using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit. Solicite al usuario la cantidad de grados centígrados para convertirlos usando las siguientes tablas de conversión:
        kelvin = celsius + 273
        fahrenheit = celsius x 18/10 + 32
            */
            Console.WriteLine("Introduzca la cantidad de Grados Celsius (Cº) que quieres convertir a Fahrenheit y Kelvin: ");
            double celsiusTemperature = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsiusTemperature * 1.8) + 32;
            double kelvin = celsiusTemperature + 273;
            Console.WriteLine($"Celsius: { celsiusTemperature }Cº ====> Fahrenheit: { fahrenheit}F");
            Console.WriteLine($"Celsius: { celsiusTemperature }Cº ====> Kelvin: { kelvin}K");
        }
    }
}
