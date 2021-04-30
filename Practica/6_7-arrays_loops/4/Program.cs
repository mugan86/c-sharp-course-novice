using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int[] valuesArray = { 1, 2, 3, 4, 5, 6 };
 
            int total = 0;
 
            for (int i = 0; i < valuesArray.Length; i++)
            {
                total += valuesArray[i];
            }
 
            double average = (double) total / valuesArray.Length;
 
            Console.WriteLine("La media es " + average);

        }
    }
}
