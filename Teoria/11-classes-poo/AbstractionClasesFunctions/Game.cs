using System;

namespace AbstractionClasesFunctions
{
    abstract class Game
    {
        public string Name 
        { get; set; }
        public Game(string name) {
            Name = name;
        }
        public abstract void PopularSentence();
        public void On() {
            Console.WriteLine("Juego {0}: En marcha", Name);
        }
    }
}
