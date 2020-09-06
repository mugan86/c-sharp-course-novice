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

            /*Console.WriteLine("Tipos de datos numéricos - Enteros - SIN signo");
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
            // Console.WriteLine(intValue);*/

            Console.WriteLine("Tipos de datos numéricos - NO Enteros");
            // double floatValue = 120202020239393939312020202023939391202020202393939393933333333333333333332120202020239393939393333333333333333333239393333333333333333333293333333333333333333212020202023939393939333333333333333333321202020202393939393933333333333333333332120202020239393939393333333333333333333212020202023939393939333333333333333333321202020202393939393933333333333333333332120202.03d;
            // SIN ERROR
            double floatValue = 1202020202393939393120202020239393912020202023939393939333333333333333333321202020202393939393933333333333333333332393933333333333333333332933333333333333333332120202020239393939393333333333333333333212020202023939393939333333333333333333321202020202393939393933333333332.03d;
            Console.WriteLine(floatValue);

        }
    }
}
