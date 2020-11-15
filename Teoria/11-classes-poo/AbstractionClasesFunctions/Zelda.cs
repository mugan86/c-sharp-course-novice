using System;

namespace AbstractionClasesFunctions
{
    class Zelda: Game
    {
        public Zelda(): base("Zelda") {}
        public override void PopularSentence() {
            Console.WriteLine("Zelda: 'Es peligroso viajar solo. Toma esto'");
        }
    }
}
