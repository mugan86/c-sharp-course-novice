using System;
using System.Collections.Generic;

namespace ListFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.- Inicializar lista y añadir valores
            List<int> numbers = new List<int>(){1, 2, 3}; // 1,2,3
            numbers.Add(10); // 1,2,3,10
            numbers.Add(700); // 1,2,3,10, 700

            // 2.- Comprobar su longitud
            int countElements = numbers.Count;

            // 3.- Insertando información en posicion concreta (Insert)

            numbers.Insert(1, 100); // 1, 100, 2,3,10, 700
            numbers.Insert(3, 45); // 1, 100, 2,45, 3,10, 700

            // 4.- Buscamos con "Contains" un elemento concreto
            bool findOneValue = numbers.Contains(1);
            bool findTwentyValue = numbers.Contains(20);
            bool findElevenValue = numbers.Contains(11);
            bool findTwentyOneValue = numbers.Contains(21);

            // Estado actual de la lista 1, 100, 2,45, 3,10, 700
            // 5.- Borramos elementos que existen y luego intentamos buscarlos
            numbers.RemoveAt(0);
             // Estado actual de la lista 100, 2,45, 3,10, 700
            findOneValue = numbers.Contains(1);
            numbers.RemoveAt(numbers.Count - 1);
             // Estado actual de la lista 100, 2,45, 3,10
            bool findValue = numbers.Contains(700);
            numbers.Add(1000);
            numbers.Add(1345);
            numbers.Add(1000);
            numbers.Add(-19);
            // 100, 2,45, 3,10, 1000, 1345, 1000, -19
            numbers.Remove(1000);
            numbers.Remove(-1);
            numbers.Remove(-50);
            numbers.Remove(1345);
            // 100, 2,45, 3,10, 1000, -19
            numbers.Clear();
            // VACIA
            Console.WriteLine("Elementos en la lista {0}", numbers.Count);
            numbers.Add(1345);
            numbers.Add(1000);
            // 1345, 1000
            Console.WriteLine("Elementos en la lista {0}", numbers.Count); // 2
        }
    }
}
