using System;
using System.Collections.Generic;

namespace QueueFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear la cola con información
            Queue<string> busStop = new Queue<string>(new string[]{
                "Conductor", "Pasajero1", "Pasajero2", "Pasajero3", "Pasajero4"
            });

            Console.WriteLine("Antes de desencolar, vamos a comprobar si existe el valor \"Conductor\": {0}",
                busStop.Contains("Conductor")
            );
            // Desencolar COnductor
            busStop.Dequeue();
            Console.WriteLine("Después de desencolar, vamos a comprobar si existe el valor \"Conductor\": {0}",
                busStop.Contains("Conductor")
            );

            busStop.Enqueue("Pasajero50");
            busStop.Enqueue("Pasajero51");
            // Usamos función Peek() => Obtener el elemento que está listo para salir (sin extraerlo)
            foreach(string busStopItem in busStop) {
                if (busStop.Peek() == busStopItem) {
                    Console.WriteLine("El primero en entrar es {0}. Como eres {0} entrarás tu primero", busStop.Peek());
                } else {
                    Console.WriteLine("El primero en entrar es {0}. Como eres {1}, tienes que esperar tu turno", busStop.Peek(), busStopItem);
                }
            }
            // "Pasajero1", "Pasajero2", "Pasajero3", "Pasajero4", "Pasajero50", "Pasajero51"
            busStop.Clear();
            busStop = new Queue<string>(new string[]{
                "Elemento1", "1", "2", "3", "4"
            });
            // "Elemento1", "1", "2", "3", "4"
            busStop.Clear();

            // Trabajamos con la función "ToArray()"
            // Iniciar nueva cola con lista de videojuegos
            Queue<string> gamesLlist = new Queue<string>(new string[] {
                "Resident Evil 2020", "Super Mario 64 3D", "Zelda", "Tomb Raider 2"
            });
            // Resident Evil 2020, Super Mario 64 3D, Zelda, Tomb Raider 2

            // Convertimos cola en un array de strings
            string [] arrayGames = gamesLlist.ToArray();

            // Modificar los elementos del index 1 y 2 (segundo y tercer elemento)

            arrayGames[1] = "Metal Gear Solid 6";
            arrayGames[2] = "Little Big Planet 6";

            // INiciar de nuevo cola con la nueva información
            gamesLlist = new Queue<string>(arrayGames);
            // Resident Evil 2020, Metal Gear Solid 6, Little Big Planet 6, Tomb Raider 2
            Console.WriteLine("Existe el valor \"Super Mario 64 3D\": {0}", gamesLlist.Contains("Super Mario 64 3D"));
            Console.WriteLine("Existe el valor \"Metal Gear Solid 6\": {0}", gamesLlist.Contains("Metal Gear Solid 6"));
        }
    }
}
