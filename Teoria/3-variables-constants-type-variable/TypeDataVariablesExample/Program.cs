using System;

namespace TypeDataVariablesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Tipos de datos numéricos - Enteros - Con signo");
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
            Console.WriteLine(intValue);*/

            Console.WriteLine("Tipos de datos numéricos - Enteros - SIN signo");
            // byte
            // byte byteInvalid = 256; // <--- ERROR sería un ushort (POR fuera de rango)
            byte byteValid = 120;
            Console.WriteLine(byteValid);
            // ushort 
            // ushort shortValue = 65536; // <-- ERROR sería un uint (Fuera de rango)
            ushort ushortValue = 1234;
            Console.WriteLine(ushortValue);

            // uint 
            uint intValue = 4294967295; // <-- ERROR sería un int
            // int intInvalidValue = -23; // <-- ERROR sería un int
            Console.WriteLine(intValue);
            // int intValue = 333344444444444;
            // Console.WriteLine(intValue);
        }
    }
}
