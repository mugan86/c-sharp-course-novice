using System;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Crear array de 5 elementos para almacenar números
            int[] numbersArray = new int[5];
            int i;
            Console.Write("\n\nAñadir y mostrar los elementos del array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Introduce 5 elementos en el array :\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Elemento - {0} : ", i + 1);
                // Convertimos lo introducido en un entero
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nLos elementos del array son: ");
            for (i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    Console.Write("{0} ", numbersArray[i]);
                }
                else
                {
                    Console.Write("{0},  ", numbersArray[i]);
                }
            }
            Console.Write("\n");
        }
    }
}
