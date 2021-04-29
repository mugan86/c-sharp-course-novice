using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Crear array de 5 elementos para almacenar números
            int[] numbersArray = new int[5];
            int i = 0;
            Console.Write("\n\nAñadir y mostrar los elementos del array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Introduce 5 elementos en el array :\n");
            while (i < 5)
            {
                Console.Write("Elemento - {0} : ", i + 1);
                // Convertimos lo introducido en un entero
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            // Reseteamos el contador
            i = 0;
            Console.Write("\nLos elementos del array son: ");
            while (i < 5)
            {
                if (i == 4)
                {
                    Console.Write("{0} ", numbersArray[i]);
                }
                else
                {
                    Console.Write("{0},  ", numbersArray[i]);
                }
                i++;
            }
            Console.Write("\n");
        }
    }
}
