using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "OneTwoThree"; // => Onetwothree

            // Vamos a usar para obtener tres números desde el texto
            string resultOne = input.Substring(0, 3);
            string resultTwo = input.Substring(3, 3);
            string resultThree = input.Substring(6);

            Console.WriteLine("Resultados: {0}-{1}-{2}", resultOne, resultTwo, resultThree);

            // Vamos a obtener mediante letra capital => Onetwothree
            string firstLetter = (input.Substring(0, 1)).ToUpper();
            string otherLetters = (input.Substring(1)).ToLower();
            Console.WriteLine("Resultado para obtener con letra capital: \n {0}{1}", firstLetter, otherLetters);
        }
    }
}
