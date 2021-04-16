using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Leer un número por teclado e indicar SI ES MÚLTIPLO de 2 (divisible de 2 = > Resto = 0)
                Resultado de los esperado:
                Introduzca un número: 35 => ¿Múltiplo de 2? false
                Introduzca un número: 34 => ¿Múltiplo de 2? true
            */
            Console.WriteLine("Introduzca el valor a evaluar:");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El número introducido es: {value} ");
            Console.WriteLine($"¿Es múltiplo de 2 el valor {value}? { value % 2 == 0} ");
        }
    }
}
