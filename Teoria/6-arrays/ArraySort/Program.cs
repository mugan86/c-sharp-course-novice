using System;

namespace ArraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            string videogamesCharacters = "Lara Croft,Nathan Drake,Mario,Ezio Auditore,Link,Jill Valentine";

            string[] videogamesCharactersArray = videogamesCharacters.Split(',');

            Array.Sort(videogamesCharactersArray);
            // Ezio Auditore, Jill Valentine, Lara Croft, Link, Mario, Nathan Drake

            // Modificar la posición index 1 y la 3 con nuevos valores
            videogamesCharactersArray[1] = "Sackboy";
            videogamesCharactersArray[3] = "Kirby";

            // Ezio Auditore, Sackboy, Lara Croft, Kirby, Mario, Nathan Drake

            // Ordenamos desde el index 1 durante 3 elementos (1, 2, 3 = indices)
            Array.Sort(videogamesCharactersArray, 1, 3);

            // Inicializar array de enteros
            int [] numbersList = {100, 1, 2, 5, 750, 1000, 234};
            // 1, 2, 5, 100, 234, 750, 1000 ==> .Sort(numbersList) ESTO NO LO APLICAMOS

            Array.Sort(numbersList, 2, numbersList.Length - 2);

            // 100, 1, 2, 5, 234, 750, 1000
        }
    }
}
