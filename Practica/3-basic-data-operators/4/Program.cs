using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Media Aritmética. Escribe un programa en C# que calcule la medía aritmética de 4 números introducidos por el usuario, uno por cada linea. El resultado debe de ESTAR EN DECIMALES.
                */
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca nota de Programación básica:");
            // Introducir el valor por teclado y al ser un string y necesitar un double
            double valueProgramBasic = Convert.ToDouble(Console.ReadLine());
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca la nota de Algoritmos:");
            // Introducir el valor por teclado y al ser un string y necesitar un double
            double valueAlgo = Convert.ToDouble(Console.ReadLine());
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca la nota de Desarrollo Móvil:");
            // Introducir el valor por teclado y al ser un string y necesitar un double
            double valueMobile = Convert.ToDouble(Console.ReadLine());
            // Pedir número con un mensaje en la consola para dar feedback
            Console.WriteLine("Introduzca la nota de Desarrollo de APIs GraphQL:");
            double valueApiGraphQL = Convert.ToDouble(Console.ReadLine());
            
            // Realizamos la media aritmética
            double finalCalification = (
                valueAlgo + valueApiGraphQL + valueMobile + valueProgramBasic
            ) / 4;

            Console.WriteLine($"La nota media obtenida de las notas del curso es {finalCalification}");
        }
    }
}
