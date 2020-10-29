using System;

namespace FunctionOverriding
{
    class Program
    {
        // Lista con dos elementos iterados
        static void GetList() {
            int i = 0;
            while(i < 3) {
                Console.WriteLine("(Por defecto) Element a mostrar: {0}", (i+1));
                i++;
            }
        }
        // Lista mostrando información de un array de tipo string
        static void GetList(string [] listElements) {
            
            for (int i = 0; i < listElements.Length; i++) {
                Console.WriteLine("Element a mostrar: {0} => {1}", (i+1), listElements[i]);
            }
        }
        // Lista mostrando información de un array de tipo bool
        static void GetList(bool[] listElements) {
            
            for (int i = 0; i < listElements.Length; i++) {
                Console.WriteLine("Element a mostrar: {0} => {1}", (i+1), listElements[i]);
            }
        }
        // Lista mostrando mensajes dependiendo de cuantas iteraciones especificamos
        static void GetList(int limit) {
            
            for (int i = 0; i < limit; i++) {
                Console.WriteLine("Element a mostrar: {0}", (i+1));
            }
        }
        static void Main(string[] args)
        {
            GetList();
            GetList(new string []{"Mario 64", "Tomb Raider", "FIFA 2021", "Metal Gear Solid"});
            GetList(new bool []{true, false, false, true, true, false});
            GetList(3);
        }
    }
}
