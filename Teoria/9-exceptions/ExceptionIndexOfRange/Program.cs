using System;

namespace ExceptionIndexOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = "";
            string [] products = new string[] {
                "Patata",
                "Filete",
                "Chocolate",
                "Videojuego",
                "Videojuego2"
            }; // 4 elementos => 0..3
            try {
                // name = "Anartz Mugika"; // 13 caracteres (0..12)
                // Console.WriteLine(name[14]);
                Console.WriteLine(products[4]);
            } catch(IndexOutOfRangeException ierEx) {
                Console.WriteLine("Fuera de rango, no hemos especificado correctamente la posición indice: " + ierEx.Message);
                // Console.WriteLine("Puedes seleccionar hasta el indice {0}", name.Length - 1);
                Console.WriteLine("Puedes seleccionar hasta el indice {0}", products.Length - 1);
            } catch (Exception ex) {
                Console.WriteLine(ex);
            } finally {
                Console.WriteLine("Final");
            }
        }
    }
}
