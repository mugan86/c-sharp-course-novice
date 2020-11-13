using System;

namespace CharacterSuperMario64
{
    class Character
    {
        // Atributos
        public string Name
        { get; set; }
        public bool Hero
        { get; set; }
        public string Alias
        { get; set; }

        // Métodos
        public void Move() {
            Console.WriteLine($"Soy { Name } y me estoy moviendo");
        }
        public void ShowDetails() {
            Console.WriteLine("====================PERSONAJE====================");
            Console.WriteLine("Nombre: {0}", Name);
            Console.WriteLine("¿Es heroe? {0}", Hero);
            Console.WriteLine("Alias: {0}", (Alias == null || Alias == "") ? "--" : Alias);
        }
    }
}
