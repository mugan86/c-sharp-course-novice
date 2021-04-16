using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Introducir un número entero y resolver las siguientes operaciones
            -6 + x * 10
            (15-2) * x
            (x + -2) * (35 / 10)
            (13 + x) / (45 - 4)
            */
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca un valor entero para obtener el resultado de las operaciones planteadas:");
            // Introducir el valor por teclado y al ser un string y necesitar un int, convertirlo
            int numberValue = Convert.ToInt32(Console.ReadLine());
            // Resultado haciendo uso del string interpolation
            Console.WriteLine("Con resultados enteros");
            Console.WriteLine($"-6 + {numberValue} * 10 =  { -6 + numberValue * 10 }");
            Console.WriteLine($"(15 - 2) * {numberValue}  =  { (15 - 2) * numberValue }");
            Console.WriteLine($"({numberValue} + -2) * (35 / 10)  =  { (numberValue + -2) * (35 / 10) }");
            Console.WriteLine($"(13 + { numberValue }) / (45 - 4) =  { (13 + numberValue) / (45 - 4) }");
            Console.WriteLine("Con resultados decimales");
            Console.WriteLine($"-6 + {numberValue} * 10 =  { (-6 + numberValue * 10) }");
            Console.WriteLine($"(15 - 2) * {numberValue}  =  { (15 - 2) * numberValue }");
            Console.WriteLine($"({numberValue} + -2) * (35 / 10)  =  { (numberValue + -2) * (35 / (double)10) }");
            Console.WriteLine($"(13 + { numberValue }) / (45 - 4) =  { (13 + numberValue) / (double)(45 - 4) }");
        }
    }
}
