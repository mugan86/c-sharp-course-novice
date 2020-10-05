using System;
using System.Collections.Generic;

namespace StackInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializar las pilas

            // Con array
            Stack<int> numbersStack = new Stack<int>(new int[]{1, 2, 3, 4, 5});
            // Como estaría la pila en este momento 
            // 5
            // 4
            // 3
            // 2
            // 1

            // Vacio
            Stack<string> namesStack = new Stack<string>();
            namesStack.Push("Anartz"); 
            namesStack.Push("Jon");
            namesStack.Push("Mikel");

            // Mikel
            // Jon
            // Anartz
            namesStack.Pop(); // Quitamos Mikel

            // Jon
            // Anartz

            namesStack.Pop();

            // Anartz

            // Mostrar la información de los elementos de la pila
            foreach(int elementNumber in numbersStack) {
                Console.WriteLine(elementNumber);
            }
            // tiene que imprimir lo siguiente
            // 5
            // 4
            // 3
            // 2
            // 1

        }
    }
}
