using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primera parte de los arrays.
            // Obtener array a partir de un string separando por espacios
            string message = "Estamos trabajando en el curso de C#";
            string[] messages = message.Split(' ');
            // Acceder a la info del primero, último y segundo elemento
            string first = messages[0];
            string last = messages[messages.Length - 1];
            string second = messages[1];
            // Segunda parte modificación de los elementos 0, 1, 2, la última
            messages[0] = "Estoy";
            messages[messages.Length - 1] = "Anartz";
            messages[1] = "aprendiendo";
            messages[2] = "con";
            string messageFinal = $"{messages[0]} {messages[1]} {messages[2]} {messages[3]} {messages[4]} {messages[5]} {messages[6]}";
            Console.WriteLine(messageFinal); // Estoy aprendiendo con el curso de Anartz
        }
    }
}
