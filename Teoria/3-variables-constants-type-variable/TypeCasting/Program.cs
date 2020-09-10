using System;

namespace TypeCasting
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo de conversión implícito");
            // char -> int -> long -> float -> double
            char character = 'a';
            int characterInt = character;
            Console.WriteLine($"Estamos convirtiendo el carácter '{character}' a un valor entero: {characterInt}");
            character = 'm';
            characterInt = character;
            Console.WriteLine($"Estamos convirtiendo el carácter '{character}' a un valor entero: {characterInt}");
            // int => double / int => float
            int numberInt = 99;
            double numberDouble = numberInt;
            float numberFloat = numberInt;
            Console.WriteLine($"Número entero {numberInt} => float {numberFloat} => double {numberDouble}");
            // Vamos a intentar convertir int en char
            int aCharacterInt = 97;
            char a = (char) aCharacterInt; // Solucionado con la conversión explícito

            Console.WriteLine("Tipo de conversión explícita");
            // double -> float -> long -> int -> char
            double valorInicial = 97.8d;
            Console.WriteLine($"Estamos convirtiendo el valor (double) '{valorInicial}' a un valor float: {(float)valorInicial}");
            Console.WriteLine($"Estamos convirtiendo el valor (double) '{valorInicial}' a un valor long: {(long)valorInicial}");
            Console.WriteLine($"Estamos convirtiendo el valor (double) '{valorInicial}' a un valor char: {(char)valorInicial}");
            Console.WriteLine("Tipo de conversión con clase Convert");
            // Aquí añadimos la referencia de la documentación: URL
            // https://docs.microsoft.com/es-es/dotnet/api/system.convert?view=netcore-3.1
            int myInt = 10;
            double myDouble = 56.234d;
            bool myBool = true;
            char myChar = 'a';
            Console.WriteLine(Convert.ToString(myInt)); // "10"
            Console.WriteLine(Convert.ToDouble(myInt)); // 10
            Console.WriteLine(Convert.ToInt32(myChar)); // 97
            Console.WriteLine(Convert.ToString(myBool)); // "True"
            Console.WriteLine(Convert.ToInt64(myDouble)); // 56
            Console.WriteLine(Convert.ToBoolean(0)); // False
            Console.WriteLine(Convert.ToBoolean(myDouble)); // True
        }
    }
}
