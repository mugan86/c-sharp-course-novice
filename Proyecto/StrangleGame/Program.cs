using System;

namespace StrangleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            do
            {
                // Vamos a aplicar el color de la fuente 
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=============AHORCADO en C#=============");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;
                if (value == "--")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opción no válida");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
                Console.WriteLine("Opciones del juego: ");
                Console.WriteLine("1) Jugar partida");
                Console.WriteLine("2) Mostrar información del autor");
                Console.WriteLine("X) Salir del juego");
                
                Console.Write("Seleccion la opción del juego: ");
                value = Console.ReadLine();
                Console.WriteLine("");
                switch (value)
                {
                    case "1":
                        Console.WriteLine("Vamos a jugar");
                        Game game = new Game();
                        game.Play();
                        break;
                    case "2":
                        Console.WriteLine("Anartz Mugika Ledo (mugan86@gmail.com");
                        Console.WriteLine("Curso \"Master en Programación C# con Visual Studio Code\"");
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("Salimos");
                        break;
                    default:
                        value = "--";
                        break;

                }
            } while (value == "--");

        }
    }
}
