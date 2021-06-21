using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escriba un programa en C# que solicite el ancho (x) y la altura (y) de un rectángulo y calcule el perímetro y el área..
                Perímetro= suma de los cuatro lados.
                Área= base x altura.
            */
            Console.WriteLine("Vamos a calcular el área y perímetro de un rectángulo");
            Console.WriteLine("Introduzca el ancho: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el alto: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"El rectángulo tiene {height} de altura y {width} de anchura.");

            // Sabiendo lo metros por segundo, si hacemos por 3.6, convertimos a velocidad en km/h
            double perimeter = 2 * width + 2 * height;
            Console.WriteLine($"El perímetro es: {perimeter}");

            // Sabiendo la velocidad en km/h, podremos obtener las millas diviendo entre 1.66
            double area = width * height;
            Console.WriteLine($"El área es: {area}");

        }
    }
}
