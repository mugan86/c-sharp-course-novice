using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una nota del 1 al 10 (incluidos)");
            int calification = Convert.ToInt32(Console.ReadLine());
            // Condicion ? true : false
            // Operador ternario simple
            string result = (calification >= 1 && calification <= 10) ?
                            "Nota correcta" : // True
                            "No has introducido correctamente la nota";
                            
            // Operador ternario compuesto
            result = (calification >= 1 && calification <= 10) ?
                            ((calification >= 5) ? "Aprobado" : "Suspenso") : // True
                            "No has introducido correctamente la nota";
        }
    }
}
