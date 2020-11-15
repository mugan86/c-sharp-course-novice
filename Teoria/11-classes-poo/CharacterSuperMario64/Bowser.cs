using System;

namespace CharacterSuperMario64
{
    class Bowser : Character
    {
        // Atributos
        public float Height
        { get; set; }
        
        public Bowser(float height = 4.5f): base("Bowser", false, "") {
            Height = height;
        }
        // Métodos

        // Escupir fuego
        public void ShootFire() {
            Console.WriteLine("Bowser está disparando fuego");
        }
        // Doble salto
        public void DobleJump() {
            Console.WriteLine("Bowser está saltando x2");
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Altura: {0}", Height);
        }
    }
}
