using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            string shoppingCartList = "Cola,Platano,Naranja,Filete,Legumbres";
            // Arrays
            string [] shoppingCartArray = shoppingCartList.Split(',');
            int [] coinsList = {100, 1, 5, 2, 1000, 750};

            Array.Sort(shoppingCartArray);
            shoppingCartArray[2] = "Sopa";
            Array.Sort(shoppingCartArray);

            Array.Sort(coinsList);
            coinsList[3] = 0;
            Array.Sort(coinsList);
            coinsList[0] = 4503;
            coinsList[3] = 7399;
            Array.Sort(coinsList, 3, coinsList.Length - 3);
        }
    }
}
