using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Introducir por teclado dos números, el primero el dividendo y el segundo el divisor. Obtener el resultado del cociente y el resto.
            Resultado esperado con un ejemplo:
            Introduzca el dividendo: 27
            Introduzca el divisor: 7
            El resultado es:
            27 / 7 = 3 
            27 % 7 = 6;
            Cociente: 3 / Resto: 6
            */
            Console.WriteLine("Introduzca el dividendo");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el divisor");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            int valueQuotient = valueOne / valueTwo;
            int valueRest = valueOne % valueTwo;

            Console.WriteLine($"Cociente: {valueQuotient} / Resto: {valueRest}");
        }
    }
}
