using System;

namespace Exercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int [] valuesList = {1, 4, 56, 6, 7};
            Console.WriteLine("Valores originales:");
            foreach(int item in valuesList) {
                Console.WriteLine(item);
            }
            Array.Reverse(valuesList);
            Console.WriteLine("Valores revertidos:");
            foreach(int item in valuesList) {
                Console.WriteLine(item);
            }
        }
    }
}
