using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		Lee un carácter por teclado y mostrar por consola el número que pertenece teniendo como referencia la lista de caracteres Unicode (esto usarlo para ver que es correcto)
		https://en.wikipedia.org/wiki/List_of_Unicode_characters#Control_codes
		*/
            Console.WriteLine("Introduce un carácter para mostrar su número decimal correspondiente: ");
            // Cogemos lo introducido por teclado y lo convertimos a un carácter
            char charInput = Convert.ToChar(Console.ReadLine());
            /*
            En este caso podemos convertirlo mediante la conversion inplícita
            ya que el espacio que ocupa en memoria "char" es menor que el que ocupa int.
            */
            int numberInput = charInput;
            // Resultado
            Console.WriteLine($"El carácter {charInput} corresponde al número decimal {numberInput}");
        }
    }
}
