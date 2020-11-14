using System;

namespace CharacterSuperMario64
{
    class Mario : Character
    {
        // Atributos
        public string Work
        { get; set; }

        public Mario(string work = "Plumber"): base("Mario", true, "") {
            Work = work;
            base.ShowDetails(); // Name, Hero, Alias
            Console.WriteLine("Profesión: {0}", Work);
        }
        
        // Métodos

        // Saltar
        public void Jump() {
            Console.WriteLine("Mario está saltando");
        }
        // Destruir bloques
        public void DestroyBlocks() {
            Console.WriteLine("Mario está destruyendo bloques");
        }
        // Coleccionar monedas
        public void CollectMoneys() {
            Console.WriteLine("Mario está recogiendo monedas");
        }
        // Correr
        public void Run() {
            Console.WriteLine("Mario está corriendo");
        }
        // Nadar
        public void Swim() {
            Console.WriteLine("Mario está nadando");
        }
    }
}
