using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recorrer array de manera incremental
            int [] numbersList = {1, 2, 4, 56, 778, 97, 889, 98};
            for (int i = 0; i < numbersList.Length; i++) {
                Console.WriteLine("Posición Index: {0} => {1}", i, numbersList[i]);
            }
            // Recorrer array de manera decremental
            for (int d = numbersList.Length - 1; d >= 0; d--) {
                Console.WriteLine("Posición Index: {0} => {1}", d, numbersList[d]);
            }
        }
    }
}
