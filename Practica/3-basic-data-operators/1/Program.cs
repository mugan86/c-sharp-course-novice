using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Escribe un programa en C# que solicite un número entero x al usuario y 
            * imprima el resultado de su número al cuadrado.
            * Pedir el dato con un mensaje en la consola "Introduzca un número entero
            * para obtener el resultado del número al cuadrado"
            * Operación = x * x 
            */
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca un valor entero para obtener el resultado al cuadrado:");
            // Introducir el valor por teclado y al ser un string y necesitar un int, convertirlo
            int numberMultiply = Convert.ToInt32(Console.ReadLine());
            // Resultado haciendo uso del string interpolation
            Console.WriteLine($"El resultado al cuadrado del número {numberMultiply} es { numberMultiply * numberMultiply}");
        }
    }
}
