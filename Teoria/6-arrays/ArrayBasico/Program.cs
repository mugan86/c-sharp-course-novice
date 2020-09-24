using System;

namespace ArrayBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primera parte
            // Iniciar mensaje de tipo string
            string msg = "Estamos trabajando en el curso de C#";
            // Vamos a crear array a partir del string
            string [] list = msg.Split(' ');
            Console.WriteLine("Lista con {0} elementos", list.Length);

            // Obtener información varias posiciones
            string first = list[0];
            string last = list[list.Length - 1];
            string second = list[1];

            // Segunda parte 
            Console.WriteLine($"Texto original: {list[0]} {list[1]} {list[2]} {list[3]} {list[4]} {list[5]} {list[6]}");
            // Estamos trabajando en el curso de C#

            // Modificando la información
            // Primera posición:
            list[0] = "Estoy"; // Estoy trabajando en el curso de C#
            list[1] =  "aprendiendo"; // Estoy aprendiendo en el curso de C#
            list[2] = "con"; // Estoy trabajando con el curso de C#
            list[list.Length - 1] = "Anartz"; // Estoy trabajando con el curso de Anartz
            Console.WriteLine($"Texto final: {list[0]} {list[1]} {list[2]} {list[3]} {list[4]} {list[5]} {list[6]}");
            // Estoy aprendiendo con el curso de Anartz
        }
    }
}
