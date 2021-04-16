using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriba un programa que tome dos números enteros como 
            entrada y devuelva verdadero o falso cuando ambos números 
            son pares o impares

            Ejemplos:
            2 y 4 ===> TRUE (Los dos pares)
            2 y 3 ===> FALSE (uno par y otro impar)
            3 y 5 ===> TRUE (los dos impares)
            */
            Console.WriteLine("Introduzca el primer valor");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            bool result = (valueOne % 2 == 0 && valueTwo % 2 == 0) ||
                          (valueOne % 2 != 0 && valueTwo % 2 != 0);

            Console.WriteLine($"¿Los dos son PARES o IMPARES? {result}");
        }
    }
}
