using System;

namespace ContentFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Anartz";
            bool result = false;
            Console.WriteLine("Equals");
            result = name.Equals("Anartz"); // true
            result = name.Equals("AnartZ"); // false
            result = name.Equals("anartz"); // false

            Console.WriteLine("StartsWith - Comienza con");
            result = name.StartsWith("Anartz"); // true
            result = name.StartsWith("Ana"); // true
            result = name.StartsWith("ana"); // false

            Console.WriteLine("EndsWith - Finaliza con");
            result = name.EndsWith("Anartz"); // true
            result = name.EndsWith("rtZ"); // false
            result = name.EndsWith("nartz"); // true
            result = name.EndsWith("rtz"); // true
        }
    }
}
