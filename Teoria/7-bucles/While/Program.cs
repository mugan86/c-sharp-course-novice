using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");
            bool print = true;
            while(print == true) {
                Console.WriteLine("Trabajando con el While.");
                Console.WriteLine("¿Seguimos mostrando el mensaje? Si = Y / y - No : cualquier carácter que no se Y");
                string inputValue = Console.ReadLine();
                print = (inputValue == "y" || inputValue == "Y") ? true : false;
            }
            Console.WriteLine("Programa finalizado");*/

            // Segunda parte

            // Introducir cuantos elementos queremos mediante teclado
            Console.WriteLine("Cuantos elementos tu lista: ");
            byte elementsCount = Convert.ToByte(Console.ReadLine());

            // Crear el array de tipo string con el número de elementos especificado
            string [] listProducts = new string[elementsCount];
            // Ir pidiendo con bucle while lo que vamos a introducir en el array
            int i = 0;
            while (i < listProducts.Length) { // i < 3
                Console.WriteLine("Dame el elemento número {0}", i + 1);
                listProducts[i] = Console.ReadLine();
                i++;
            }
            i = 0;
            // Mostrar la información en otro bucle while
             while (i < listProducts.Length) { // i < 3
                Console.WriteLine("El elemento número {0}: {1}", i + 1, listProducts[i]);
                i++;
            }
        }
    }
}
