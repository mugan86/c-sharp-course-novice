using System;
using System.Collections.Generic;

namespace ListInitializeForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.- Creamos dos listas. La primera con números enteros y la segunda con strings
            // Tiene que tener 3-4 elementos
            List<int> numbers = new List<int>(){1, 23, -4, 56};
            List<string> products = new List<string>(){"Patatas", "Manzana", "Refresco de Limón", "Macarrones"};
            // 2.- Contar cuantos elementos en cada lista
            Console.WriteLine("Elementos de la lista de números: {0}", numbers.Count);
            Console.WriteLine("Elementos de la lista de productos: {0}", products.Count);
            // 3.- Visualizar la información individualmente
            
            Console.WriteLine("Vamos a visualizar los elementos de la lista de enteros:");
            foreach(int numberItem in numbers) {
                Console.WriteLine(numberItem);
            }

            Console.WriteLine("Vamos a visualizar los elementos de la lista de productos:");
            foreach(string productItem in products) {
                Console.WriteLine(productItem);
            }
        }
    }
}
