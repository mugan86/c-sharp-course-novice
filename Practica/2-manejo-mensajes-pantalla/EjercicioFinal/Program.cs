using System;

namespace EjercicioFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducir la información
            Console.WriteLine("Nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Apellidos: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Edad: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hobby: ");
            string hobby = Console.ReadLine();
            // Mostrar la información 
            Console.WriteLine("=========INFORMACIÓN BÁSICA=========");
            Console.WriteLine($"Eres {name} {lastname}.");
            Console.WriteLine($"Tienes {age} años.");
            Console.WriteLine($"Hobby: { hobby }");
            Console.WriteLine("====================================");
        }
    }
}
