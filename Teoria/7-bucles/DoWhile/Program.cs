using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.- Inicializar variables
            int sumCalifications = 0;
            int totalCalifications = 0;
            bool stopInput = false;

            // 2.- Programa principal con el do

            do {
                Console.WriteLine("Introduce tu reseña entre 0 y 5 (incluidos): ");
                int calification = Convert.ToInt32(Console.ReadLine());
                // Comprobar que calificaciones están correctas (en el rango)
                if (calification >= 0 && calification <= 5) {
                    totalCalifications++;
                    sumCalifications += calification; // sumCalifications = sumCalifications + calification;
                } else {
                    stopInput = true;
                }
            } while (!stopInput);

            // 3.- Promedio de las reseñas
            double avgPoints = (double) sumCalifications / totalCalifications;
            Console.WriteLine("Calificaciones totales: {0} Promedio: {1}", totalCalifications, avgPoints);
        }
    }
}
