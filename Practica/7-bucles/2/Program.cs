using System;

namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int valuesCount = 0;
            // Especificar cuantos elementos vamos a introducir
            do
            {
                Console.Write("Introduce cuantos elementos tiene el array (1 a 10) :\n");
                valuesCount = Convert.ToInt32(Console.ReadLine());
                if (valuesCount > 10 || valuesCount < 1)
                {
                    Console.WriteLine("Tienes que introducir un valor correcto. De 1 a 10");
                }
            } while (valuesCount > 10 || valuesCount < 1);

            // Crear array de elementos especificados para almacenar números
            int[] numbersArray = new int[valuesCount];
            int i;
            Console.Write("\n\nAñadir y mostrar los elementos del array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Introduce {0} elementos en el array :\n", valuesCount);
            for (i = 0; i < valuesCount; i++)
            {
                Console.Write("Elemento - {0} : ", i + 1);
                // Convertimos lo introducido en un entero
                numbersArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nLos elementos del array son: ");
            for (i = 0; i < valuesCount; i++)
            {
                if (i == valuesCount - 1)
                { // Último elemento
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
