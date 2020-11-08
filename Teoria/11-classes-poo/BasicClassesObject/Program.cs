using System;

namespace BasicClassesObject
{
    class Program {
        static void Main(string[] args)
        {
            Level theGreatWall = new Level();
            theGreatWall.Game = "Tomb Raider 2";
            theGreatWall.LocationName = "China";
            theGreatWall.Name = "La Gran Muralla / The Great Wall";
            theGreatWall.Order = 1;
            theGreatWall.Secret = false;
            theGreatWall.ShowDetails();
            Level venecia = new Level();
            venecia.Game = "Tomb Raider 2";
            venecia.LocationName = "Venecia (Italia)";
            venecia.Name = "Venecia";
            venecia.Order = 2;
            venecia.Secret = false;
            venecia.ShowDetails();
            Level bartolisHideout = new Level();
            bartolisHideout.Game = "Tomb Raider 2";
            bartolisHideout.LocationName = "Venecia (Italia)";
            bartolisHideout.Name = "El escondite de Bartoli";
            bartolisHideout.Order = 3;
            bartolisHideout.Secret = true;
            bartolisHideout.ShowDetails();
            Level operaHouse = new Level();
            operaHouse.Game = "Tomb Raider 2";
            operaHouse.LocationName = "Venecia (Italia)";
            operaHouse.Name = "La casa de la Opera";
            operaHouse.Order = 4;
            operaHouse.Secret = true;
            operaHouse.ShowDetails();
        }
    }
    class Level
    {
        public string Name, Game, LocationName;
        public int Order;
        public bool Secret;

        public void ShowDetails() {
            Console.WriteLine("================== NIVELES======================");
            Console.WriteLine("Nombre: {0}", Name);
            Console.WriteLine("Juego: {0}", Game);
            Console.WriteLine("Localización: {0}", LocationName);
            Console.WriteLine("Número: {0}", Order);
            Console.WriteLine("Secreto: {0}", Secret);
        }
    }
}
