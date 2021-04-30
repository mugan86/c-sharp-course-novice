using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesList = {1, 4, 6, 5, 44, 3, 2, 5, -1, 57};
            string oddValues = "";
            string evenValues = "";
            string arrayValues = "{";
            
            for (int i = 0; i < valuesList.Length; i++) {
                if (valuesList[i] % 2 == 0) {
                    oddValues += String.Format("{0} ", valuesList[i]);
                } else {
                    evenValues += String.Format("{0} ", valuesList[i]);
                }
                arrayValues = (valuesList.Length -1 > i) ? 
                                arrayValues +  valuesList[i] + " " :
                                 arrayValues +  valuesList[i] + "}";
            }
            Console.WriteLine(String.Format("Valores: {0}", arrayValues));
            Console.WriteLine("Valores pares: " + oddValues);
            Console.WriteLine("Valores impares: " + evenValues);
        }
    }
}
