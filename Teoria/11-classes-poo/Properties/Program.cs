using System;

namespace Properties
{
    class Character {
        
        // Propiedades
        public string Name 
        { get; set; }
        public string Game 
        { get; set; }

        public Character() {
            Name = "Mario".ToLower();
            Game = "Super Mario Bros 3";
        }
        public void ShowDetails() {
            Console.WriteLine("====================PERSONAJE====================");
            Console.WriteLine("Nombre: {0}", Name);
            Console.WriteLine("Juego: {0}", Game);
        }
    }
    class Program
    { 
        
        static void Main(string[] args)
        {
            Character program = new Character();
            program.Name = "Anartz Mugika";
            program.Game = "Aventuras de Anartz Mugika";
            program.ShowDetails();
        }
    }
}
