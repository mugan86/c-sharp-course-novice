using System;

namespace IfStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // if simple
            /*Console.WriteLine("Introduce un número del 1 al 10");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            if (numberInput > 10) {
                Console.WriteLine("Has introducido el siguiente número {0} y es mayor que 10", numberInput);
            }
            if (numberInput > 10 || numberInput < 0) {
                Console.WriteLine("No has escrito un valor válido");
            }

            if (numberInput <= 10 && numberInput > 0) { // 1-10
                Console.WriteLine("Estás en el rango");
            }*/

            // If else
            /*Console.WriteLine("Escribe tu nombre: ");
            string name = Console.ReadLine();

            if (name == "Anartz") {
                Console.WriteLine("Te llamas Anartz");
            } else {
                Console.WriteLine("Oye, tu no eres Anartz. Eres {0}", name);
            }

            // Vamos a poner para trabajar con números y operadores / relacionales - lógicos
            Console.WriteLine("Número 1: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número 2: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número 3: ");
            int numberThree = Convert.ToInt32(Console.ReadLine());
            if (name == "Anartz" && (numberOne < numberTwo || numberTwo > numberThree)) {
                Console.WriteLine("Cumple las condiciones númericas y del nombre");
            } else {
                Console.WriteLine("No cumple las condiciones");
            }

             if ((name == "Anartz" || name[0] == 'A' || name[0] == 'a' ) && (numberOne < numberTwo || numberTwo > numberThree)) {
                Console.WriteLine("Cumple las condiciones númericas y del nombre (Parte 2)");
            } else {
                Console.WriteLine("No cumple las condiciones");
            }*/
            // If ElseIf Else
            /*
           Sobresaliente (SB) = 9 o 10
           Notable (NT) = 7 o 8
           Bien (BI) = 6
           Suficiente (SU) = 5
           Insuficiente (IN) = 1, 2, 3 o 4
           */
            /*Console.WriteLine("Introduzca la nota entre 1 y 10 (incluidos):");
            int calification = Convert.ToInt32(Console.ReadLine());
            if (calification == 9 || calification == 10)
            {
                Console.WriteLine("Sobresaliente (SB)");
            }
            else if (calification == 7 || calification == 8)
            {
                Console.WriteLine("Notable (NT)");
            }
            else if (calification == 6)
            {
                Console.WriteLine("Bien (Bi)");
            }
            else if (calification == 5)
            {
                Console.WriteLine("Suficiente (SU)");
            }
            else
            {
                Console.WriteLine("Insuficiente (IN)");
            }*/
            // If Anidado con If else if else
            Console.WriteLine("Introduzca la nota entre 1 y 10 (incluidos):");
            int calification = Convert.ToInt32(Console.ReadLine());
            if (calification >= 1 && calification <= 10)
            {
                Console.WriteLine("Nota introducida correctamente");
                if (calification == 9 || calification == 10)
                {
                    Console.WriteLine("Sobresaliente (SB)");
                }
                else if (calification == 7 || calification == 8)
                {
                    Console.WriteLine("Notable (NT)");
                }
                else if (calification == 6)
                {
                    Console.WriteLine("Bien (Bi)");
                }
                else if (calification == 5)
                {
                    Console.WriteLine("Suficiente (SU)");
                }
                else
                {
                    Console.WriteLine("Insuficiente (IN)");
                }
            }
            else
            {
                Console.WriteLine("Tienes que introducir una nota válida dentro del rango. Has introducido {0}", calification);
            }

        }
    }
}
