using System;

namespace CharacterSuperMario64
{
    class Bowser : Character
    {
        // Atributos
        public float Height
        { get; set; }
        
        // Métodos

        // Escupir fuego
        public void ShootFire() {
            Console.WriteLine("Bowser está disparando fuego");
        }
        // Doble salto
        public void DobleJump() {
            Console.WriteLine("Bowser está saltando x2");
        }
    }
}
