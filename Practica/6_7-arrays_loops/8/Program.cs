using System;

namespace Exercise
{
    class Program
    {
        // Dado un array de números, muestra el mayor y el menor.
        static void Main(string[] args)
        {

            int[] intArray = { 4, 3, 7, 10, 100, 5, 7 };

            Array.Sort(intArray);

            int max = intArray[intArray.Length - 1];
            int min = intArray[0];

            Console.WriteLine("El valor minimo es: " + min);
            Console.WriteLine("El valor maximo es: " + max);
        }
    }
}
