using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe un programa en C# que multiplique por tres factores. Solicita tres números enteros al usuario y muestra el resultado de multiplicarlos entre sí.
            P.j: 
            Introduzca valor 1: 2
            Introduzca valor 2: 45
            Introduzca valor 3: 1
            Resultado = valor_1 * valor_2 * valor_3
            Resultado = 2 * 45 * 1 = 90
            */
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca el primer valor entero:");
            // Introducir el valor por teclado y al ser un string y necesitar un int, convertirlo a valor 1
            int valueOne = Convert.ToInt32(Console.ReadLine());
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca el segundo valor entero:");
            // Introducir el valor por teclado y al ser un string y necesitar un int, convertirlo a valor 1
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca el tercer valor entero:");
            // Introducir el valor por teclado y al ser un string y necesitar un int, convertirlo a valor 1
            int valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El resultado de la multiplicación {valueOne} * {valueTwo} * {valueThree} es {valueOne * valueTwo * valueThree}");
        }
    }
}
