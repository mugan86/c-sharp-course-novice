using System;

namespace OperatorsRelational
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 78, y = 67, z = 78;
            // Igualdad
            bool result = x == y; // x = 78 / y = 67 => false
            result = x == z; // x = 78 / z = 78 => true
            // No iguales
            result = x != y; // x = 78 / y = 67 => true
            result = x != z; // x = 78 / z = 78 => false
            // Mayor que
            result = x > y; // x = 78 / y = 67 => true
            result = x > z; // x = 78 / z = 78 => false
            // Menor que
            result = x < y; // x = 78 / y = 67 => false
            result = x < z; // x = 78 / z = 78 => false
            // Mayor o igual que
            result = x >= y; // x = 78 / y = 67 => true
            result = x >= z; // x = 78 / z = 78 => true
            // Menor o igual que
            result = x <= y; // x = 78 / y = 67 => false
            result = x <= z; // x = 78 / z = 78 => true
        }
    }
}
