using System;

namespace ArrayIndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] sagas = {
                "Tomb Raider", "Devil May Cry", "Resident Evil", "Resident Evil", "Mario",
                "Final Fantasy", "Zelda", "Silent Hill", "Resident Evil", "Metal Gear", "Sonic",
                "Tekken"
            };

            string searchString = "Resident Evil";
            // Buscar Resident Evil en todo el array
            int positionFind = Array.IndexOf(sagas, searchString); // 2

            // Buscar Resident Evil a partir de la posición indice 3
            positionFind = Array.IndexOf(sagas, searchString, 3); // 3

            // Buscar Resident Evil a partir de la posición indice 4 durante 4 elementos
            positionFind = Array.IndexOf(sagas, searchString, 4, 4); // -1
            
            // Buscar Resident Evil a partir de la posición indice 4 durante 4 elementos
            positionFind = Array.IndexOf(sagas, searchString, 4, 6); // 8

        }
    }
}
