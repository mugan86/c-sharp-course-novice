using System;
using System.Collections.Generic;

namespace QueueInitialize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear cola con la información añadida
            Queue<string> busStop = new Queue<string>(new string[] {
                "Conductor", "Pasajero1", "Pasajero2", "Pasajero3"
            });
            busStop.Dequeue(); // "Pasajero1", "Pasajero2", "Pasajero3"
            foreach(string busStopItem in busStop) {
                Console.WriteLine(busStopItem);
            }

            // Vamos a crear una cola vacia y añadimos la información desde la consola mediante el teclado
            Queue<string> giftsElements = new Queue<string>();
            string valueInput = "";
            do {
                Console.WriteLine("Introduce el elemento de regalo: ");
                valueInput = Console.ReadLine();
                if (valueInput != "") {
                    giftsElements.Enqueue(valueInput);
                }
            } while(valueInput != "");
        }
    }
}
