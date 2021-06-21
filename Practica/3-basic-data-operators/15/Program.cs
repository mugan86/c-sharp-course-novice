using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
		https://es.wikipedia.org/wiki/Esfera#%C3%81rea
    superficie (área) = 4 * pi * radio al cuadrado
		https://es.wikipedia.org/wiki/Esfera#Volumen
    volumen = (4 * pi * radio al cubo) / 3

		*/
            const double PI = 3.14159265358979323846;
            Console.WriteLine("Introduce el radio en metros para calcular su área y volumen:");
            double radix = Convert.ToDouble(Console.ReadLine());
            double area = 4 * PI * (radix * radix);
            double volume = ((4) * PI * (radix * radix * radix)) / 3;

            Console.WriteLine($"El área de la esfera teniendo como radio {radix} es de {area} metros cuadrados");

            Console.WriteLine($"El volumen de la esfera teniendo como radio {radix} es de {volume} metros cúbicos");
        }
    }
}
