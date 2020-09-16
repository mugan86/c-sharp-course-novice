using System;

namespace ToUpperLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOne = "aaaaaaeeeEEEE";
            string textTwo = "AAfi";
            string textThree = "AAHD";
            string result = "";
            Console.WriteLine("Convertir a mayúsculas - ToUpper()");
            result = textOne.ToUpper(); // AAAAAAEEEEEEE
            result = textTwo.ToUpper(); // AAFI
            result = textThree.ToUpper(); // AAHD

            Console.WriteLine("Convertir a minúsculas - ToLower()");
            result = textOne.ToLower(); // aaaaaaeeeeeee
            result = textTwo.ToLower(); // aafi
            result = textThree.ToLower(); // aahd

        }
    }
}
