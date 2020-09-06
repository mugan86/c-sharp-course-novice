using System;

namespace TypeDataVariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de datos numéricos - Enteros - Con signo");
            // sbyte
            // sbyte sbyteInvalid = 130; <--- ERROR sería un short
            sbyte sbyteValid = 120;
            Console.WriteLine(sbyteValid);
            // short 
            // short shortValue = 3323939; <-- ERROR sería un int
            short shortValue = 23939;
            Console.WriteLine(shortValue);

            // int 
            // int intValue = 332393944444444; // <-- ERROR sería un int
            shortValue = 3333;
            Console.WriteLine(shortValue);
            int intValue = 333344444444444;
            Console.WriteLine(intValue);

            
            
        }
    }
}
