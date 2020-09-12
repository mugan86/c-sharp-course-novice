using System;

namespace OperatorsAsignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a asignar el valor");
            int x = 165; // Asignación simple ==> x = valor que queremos asignar
            Console.WriteLine("Vamos a asignar el valor haciendo suma +=");
            x += 10; // x = x + 10 => x = 165 + 10 = 175
            Console.WriteLine("Vamos a asignar el valor haciendo resta -=");
            x -= 55; // x = x -55 => x = 175 - 55 = 120
            Console.WriteLine("Vamos a asignar el valor haciendo multi *=");
            x *= 10; // x = x * 10 => x = 120 + 10 = 1200
            Console.WriteLine("Vamos a asignar el valor haciendo división /=");
            x /= 100; // x = x / 100 => x = 1200 / 100 = 12
            Console.WriteLine("Vamos a asignar el valor haciendo módulo %=");
            x %= 7; // x = x % 7 => x = 12 % 7 = 5 ( 12 / 7 = 1 => x = 5)
            Console.WriteLine($"Empezamos con el valor 165 y terminamos con el valor {x}");
        }
    }
}
