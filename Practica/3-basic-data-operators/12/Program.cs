using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		        Escribe un programa en C# que calcule el resultado de sumar, restar, 
                multiplicar y dividir (habilitar para números decimales) dos números 
                enteros introducidos por el usuario.
                Además también debería calcular el resto de la división en la última 
                linea (módulo - %)
            */
            Console.WriteLine("Introduce el primer número");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            // Resultado
            Console.WriteLine($"{numberOne} + {numberTwo} = {numberOne + numberTwo}");
            Console.WriteLine($"{numberOne} - {numberTwo} = {numberOne - numberTwo}");
            Console.WriteLine($"{numberOne} * {numberTwo} = {numberOne * numberTwo}");
            Console.WriteLine($"{numberOne} / {numberTwo} = {numberOne / (double)numberTwo}");
            Console.WriteLine($"{numberOne} % {numberTwo} = {numberOne % numberTwo}");
        }
    }
}
