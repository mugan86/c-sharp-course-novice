using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		Introducir dos valores numéricos por teclado y preguntar SI SON IGUALES. También preguntamos si el primero es igual o mayor que el segundo (similar al anterior)
		*/
            Console.WriteLine("Introduzca el primer valor a comparar");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor paraa comparar con el primero");
            int valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"¿El valor {valueOne} es igual al valor {valueTwo} ? {valueOne == valueTwo }");
            Console.WriteLine($"¿El valor {valueOne} es mayor o igual al valor {valueTwo} ? {valueOne >= valueTwo }");
        }
    }
}
