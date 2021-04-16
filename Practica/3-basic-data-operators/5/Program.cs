using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Declara dos variables numéricas ENTERAS y pregunta 
            mediante un operador relacional SI SON IGUALES
            */
            int valueOne = 34;
            int valueTwo = 35;

            Console.WriteLine($"El valor {valueOne} es igual al valor" +
            $"{valueTwo} ? {valueOne == valueTwo }");
        }
    }
}
