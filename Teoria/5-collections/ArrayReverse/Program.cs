using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbersInt = {1,2,3,4,5};

            Array.Reverse(numbersInt);

            // Modificar algunos valores
            numbersInt[2] = 456;
            numbersInt[3] = 35280;

            Array.Reverse(numbersInt, 2, numbersInt.Length - 2);

        }
    }
}
