using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa C# que muestre el resultado de la siguiente operación:x^2 + 2x + 1 (x*x + 2*x +1)introduciendo un valor decimal
         Comprobar mediante un operador relacional si el resultado se encuentra en el rango -5, 5 (incluidos los dos valores mínimos y máximo)
            */
            Console.WriteLine("Introduce el valor de la incógnita para realizar la operación x^2 + 2x + 1: ");
            double inputValue = Convert.ToDouble(Console.ReadLine());
            double result = (inputValue * inputValue) + 2 * inputValue + 1;
            Console.WriteLine($"El resultado es: {result}");

            Console.WriteLine($"¿El resultado {result} está dentro del rango -5, 5? {result >= -5 && result <= 5}");
        }
    }
}
