using System;
using System.Collections.Generic;

namespace StackFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pagesStack = new Stack<string>(new string[]{
                "index", "blog", "article-1", "article-2"
            });

            // Añadir varios elementos más
            pagesStack.Push("home");
            pagesStack.Push("contact");
            Console.WriteLine("Elementos en la pila: {0}", pagesStack.Count);
            // Estado de la pila
            // contact
            // home
            // article-2
            // article-1
            // blog
            // index
            // Usando "Contains"
            Console.WriteLine("¿Tenemos el elemento \"contact\" en la pila ?: {0}", pagesStack.Contains("contact"));
            Console.WriteLine("¿Tenemos el elemento \"homes\" en la pila ?: {0}", pagesStack.Contains("homes"));
            Console.WriteLine("¿Tenemos el elemento \"blog\" en la pila ?: {0}", pagesStack.Contains("blog"));

            // Eliminar 5 elementos
            int i = 0;
            while(i < 5) {
                pagesStack.Pop();
                Console.WriteLine(pagesStack.Peek());
                i++;
            }
            // Estado de la pila
            // index

            // Vamos a añadir elementos para borrarlos con "Clear()"
            pagesStack.Push("anartz");
            pagesStack.Push("contact");
            // Estado de la pila
            // contact
            // anartz
            // index

            pagesStack.Clear();

            pagesStack.Push("anartz2");
            pagesStack.Push("contact2");
            // Estado de la pila
            // contact2
            // anartz2
            pagesStack.Clear();

            // COmprobamos de nuevo si existen
            Console.WriteLine("¿Tenemos el elemento \"contact\" en la pila ?: {0}", pagesStack.Contains("contact"));
            Console.WriteLine("¿Tenemos el elemento \"homes\" en la pila ?: {0}", pagesStack.Contains("homes"));
            Console.WriteLine("¿Tenemos el elemento \"blog\" en la pila ?: {0}", pagesStack.Contains("blog"));
        }
    }
}
