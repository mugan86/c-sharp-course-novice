using System;

namespace SwitchStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la nota entre 1 y 10 (incluidos):");
            int calification = Convert.ToInt32(Console.ReadLine());
            switch(calification) {
                case 9:
                case 10:
                    Console.WriteLine("Sobresaliente (SB)");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notable (NT)");
                    break;
                case 6:
                    Console.WriteLine("Bien (Bi)");
                    break;
                case 5:
                    Console.WriteLine("Suficiente (SU)");
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Insuficiente (IN)");
                    break;
                default:
                    Console.WriteLine("Tienes que introducir una nota válida dentro del rango. Has introducido {0}", calification);
                    break;
            }
        }
    }
}
