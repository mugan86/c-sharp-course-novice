using System;

namespace AbstractionClasesFunctions
{
    class Zelda: IGame, IDiscount
    {
        public void ApplyDiscount(double price, double percent)
        {
            Console.WriteLine(price - (price * percent / 100));
        }

        public void On()
        {
            Console.WriteLine("Juego Zelda: En marcha");
        }

        public void PopularSentence() {
            Console.WriteLine("Zelda: 'Es peligroso viajar solo. Toma esto'");
        }
    }
}
