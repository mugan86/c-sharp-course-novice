using System;

namespace EscapeChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            Console.WriteLine("Nueva línea");
            result = "Anartz\nMugika\nLedo";
            Console.WriteLine(result);

            Console.WriteLine("Tabulador");
            result = "Anartz\t\tMugika\tLedo";
            Console.WriteLine(result);

            Console.WriteLine("Contra barra");
            result = "Anartz\\Mugika\\Ledo";
            Console.WriteLine(result);

            Console.WriteLine("Comillas dobles y simples");
            result = "\"Anartz\" 'Mugika'\n\"Ledo\"";
            Console.WriteLine(result);


            Console.WriteLine("Retorno de carro ");
            result = "Ana\rrtzMugika\nLedo";
            Console.WriteLine(result);
            
        }
    }
}
