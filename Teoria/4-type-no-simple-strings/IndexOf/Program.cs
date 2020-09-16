using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "-> ¡Hola Anartz! Voy a aprender C# en Master Devs (https://formacion.masterdevs.es/) ¡Animate!";
            // Buscando "Anartz"
            int findAnartz = message.IndexOf("Anartz", 3); // 9

            findAnartz = message.IndexOf("Anartz", 8); // 9

            findAnartz = message.IndexOf("Anartz", 15); // -1
            // Buscando "Master Devs"
            int findMaster = message.IndexOf("Master Devs"); // 38

            findMaster = message.IndexOf("Master Devs", 40); // -1

            findMaster = message.IndexOf("Master Devs", 38, 12); // -1

            // Solución de la práctica para obtener la frase de "Voy a aprender..."

            int startPosition = message.IndexOf("Voy a aprender"); // Posición inicial
            int finalPosition = message.IndexOf(" ¡Animate!");

            string finalString = message.Substring(startPosition, finalPosition - startPosition);
            Console.WriteLine("Tener en cuenta: {0}", finalString);
        }
    }
}
