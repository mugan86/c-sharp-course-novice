using System;

namespace AbstractionClasesFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Zelda zelda = new Zelda();
            zelda.On();
            zelda.PopularSentence();
            zelda.ApplyDiscount(100, 26); // 74
            zelda.ApplyDiscount(100, 49); // 51
            zelda.ApplyDiscount(123, 33); // 82.41
        }
    }
}
