using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Lee un número por teclado y mostrar por consola el carácter que pertenece teniendo como referencia la lista de caracteres Unicode (esto usarlo para ver que es correcto)
            https://en.wikipedia.org/wiki/List_of_Unicode_characters#Control_codes
		    */
            Console.WriteLine("Introduce un número para mostrar su carácter");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            /*
            En este caso podemos convertirlo mediante la conversion explícita
            ya que el espacio que ocupa en memoria "int" es mayor que el que ocupa "char" por lo que añadimos el operador para la conversión explícita.
            */
            char inputChar = (char)numberInput;
            // Resultado
            Console.WriteLine($"El número {numberInput} corresponde al carácter '{inputChar}'");
        }
    }
}
