using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar un string caracter a caracter con for each
            string name = "Anartz";
            int nameCount = 1;
            foreach (char valueChar in name)
            {
                Console.WriteLine("{0}: {1}", nameCount, valueChar);
                nameCount++;
            }
            Console.WriteLine("========== VAMOS A HACERLO CON UN ARRAY===========");
            // Trabajamos con un array de enteros
            int[] numbersList = { 1, 2, 3, 45, 45, 56 };
            int itemCount = 1;
            foreach (int numberItem in numbersList)
            {
                Console.WriteLine("{0}: {1}", itemCount, numberItem);
                itemCount++;
            }
        }
    }
}
