using System;
using System.Collections.Generic;

namespace DictionaryBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.- Inicializar
            // a- Sin valores
            Dictionary<int, string> numbersReference = new Dictionary<int, string>();
            try {
                numbersReference.Add(1, "One");
                numbersReference.Add(2, "Two");
            } catch (Exception e) {
                Console.WriteLine("Excepción: {0}", e.ToString());
            }
            // b- con valores
            Dictionary<string, string> videoGamesList = new Dictionary<string, string>() {
                {"TR", "Tomb Raider"},
                {"SM64", "Super Mario 64"},
                {"SMKART", "Mario Kart 64"},
                {"TK1", "Tekken"}
            };

            // 2.- Mostrar cuantos elementos por diccionario
            Console.WriteLine("Elementos de referencia números {0}", numbersReference.Count);
            Console.WriteLine("Elementos de referencia videojuegos {0}", videoGamesList.Count);
            // 3.- Recorrer elementos de un diccionario

            foreach( KeyValuePair<string, string> kvp in videoGamesList )
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            // 4.- Trabajamos con la función "ContainsKey"
            Console.WriteLine("Existe la clave 1 en referencia de números: {0}", numbersReference.ContainsKey(1)); // true
            Console.WriteLine("Existe la clave 5 en referencia de números: {0}", numbersReference.ContainsKey(5)); // false
            Console.WriteLine("Existe la clave -1 en referencia de números: {0}", numbersReference.ContainsKey(-1)); // false
            // Videojuegos
            Console.WriteLine("Existe la clave \"TR\" en referencia de videojuegos: {0}", videoGamesList.ContainsKey("TR")); // true
            Console.WriteLine("Existe la clave \"TR2\" en referencia de videojuegos: {0}", videoGamesList.ContainsKey("TR2")); // false
            Console.WriteLine("Existe la clave \"SM64\" en referencia de videojuegos: {0}", videoGamesList.ContainsKey("SM64")); // true

            // 5.- Trabajamos con la función "ContainsValue"
            Console.WriteLine("Existe el valor \"One\" en referencia de números: {0}", numbersReference.ContainsValue("One")); // true
            Console.WriteLine("Existe el valor \"Five\" en referencia de números: {0}", numbersReference.ContainsValue("Five")); // false
            Console.WriteLine("Existe el valor \"Minus One\" en referencia de números: {0}", numbersReference.ContainsValue("Minus One")); // false
            // Videojuegos
            Console.WriteLine("Existe el valor \"Tomb Raider\" en referencia de videojuegos: {0}", videoGamesList.ContainsValue("Tomb Raider")); // true
            Console.WriteLine("Existe el valor \"Tomb Raider 2\" en referencia de videojuegos: {0}", videoGamesList.ContainsValue("Tomb Raider 2")); // false
            Console.WriteLine("Existe el valor \"Super Mario 64\" en referencia de videojuegos: {0}", videoGamesList.ContainsValue("Super Mario 64")); // true
        
            // 6.- Borrar elementos si existen con "Remove"
            numbersReference.Remove(1); // true => Borra el elemento => {{2, "Two"}}
            Console.WriteLine("Elementos de referencia números {0}", numbersReference.Count);
            numbersReference.Remove(5);

            videoGamesList.Remove("TK1"); // true => Borrar el último elemento
            Console.WriteLine("Elementos de referencia videojuegos {0}", videoGamesList.Count);
            videoGamesList.Remove("TT");

            // 7.- Borrar los elementos del diccionario
            numbersReference.Clear();
            videoGamesList.Clear();
        }
    }
}
