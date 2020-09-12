using System;

namespace OperatorsAritmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo Binario");
            Console.WriteLine("Sumas (+)");
            Console.WriteLine($"5 + 4 + 56 + 34 = {5 + 4 + 56 + 34}"); // 99
            Console.WriteLine($"5.34d + 4.34d + 56 + 34 = {5.34d + 4.34d + 56 + 34}"); // 99.68
            Console.WriteLine($"(-25) + 4 + (-56) + 34 = {(-25) + 4 + (-56) + 34}"); // -43
            Console.WriteLine("Restas (-)");
            Console.WriteLine($"5 - 4 - 6 - 4 = {5 - 4 - 6 - 4}"); // -9
            Console.WriteLine($"5.34d - 4.34d -1.5d = {5.34d - 4.34d - 1.5d}"); // -0.5
            Console.WriteLine($"(-25.5f) + 4.5f + (-56) + 34 = {(-25.5f) + 4.5f + (-56) + 34}"); // -43

            Console.WriteLine("Multiplicación (-)");
            Console.WriteLine($"5 * 4 * 6 = {5 * 4 * 6}"); // 120
            Console.WriteLine($"5 * 4 * -6 = {5 * 4 * (-6)}"); // -120
            Console.WriteLine($"5 * (-4) * (-6) = {5 * (-4) * (-6)}"); // 120
            Console.WriteLine($"2.5f * 5 = {2.5f * 5}"); // 12.5
            Console.WriteLine($"2.5f * -5 = {2.5f * -5}"); // -12.5

            Console.WriteLine("Combinar operadores (+, -, *)");
            Console.WriteLine($"((5 * 4) + 65 -45) * 5 = {((5 * 4) + 65 - 45) * 5}"); // 200
            Console.WriteLine($"5 * 4 + 65 -45 * 5 = {5 * 4 + 65 - 45 * 5}"); // -140


            Console.WriteLine("Divisiones (/)");
            Console.WriteLine($"20 / 5 = {20 / 5}"); // 4
            Console.WriteLine($"20 / 5 / 5d = {20 / 5 / 5d}"); // 0.8
            Console.WriteLine($"(-20) / (-5) / 5d = {(-20) / (-5) / 5d}"); // 0.8
            Console.WriteLine($"(-20) / (5) / 5d = {(-20) / (5) / 5d}"); // -0.8
            Console.WriteLine($"(-20) / (-5) / (-5d) = {(-20) / (-5) / (-5d)}"); // -0.8
            Console.WriteLine($"(-20) / (-5) / (-5d) / (-4) = {(-20) / (-5) / (-5d) / (-4)}"); // 0.2

            Console.WriteLine("Módulo (resto) (%)");
            Console.WriteLine($"20 % 5 = {20 % 5}"); // 0
            Console.WriteLine($"20 % 6 = {20 % 6}"); // 2

            Console.WriteLine("Combinar operadores (+, -, *, / , %)");
            Console.WriteLine($"(((5 * 4) + 65 -45) * 5) % 40 = {(((5 * 4) + 65 - 45) * 5) % 40 }"); // 0
            Console.WriteLine("Tipo Unario");
            // Postfijo x++ x--
            // Prefijo --x ++x
            // Valor existente +
            // Negación -
            int valor = 34;
            Console.WriteLine($"Mostrar el valor inicializado: {valor}"); // 34
            Console.WriteLine($"Prefijo (--): {--valor}"); // 33
            Console.WriteLine($"Posfijo (--): {valor--}"); // 33 (lo que se muestra) => valor real 32
            Console.WriteLine($"Valor en este momento: {valor}"); // 32
            Console.WriteLine($"x++ => x++ => ++x {valor++} {valor++} {++valor}"); // 32 => 33 => 35
            valor = +valor;
            Console.WriteLine($"Valor en este momento: {valor}"); // 35
            valor = -valor;
            Console.WriteLine($"Valor en este momento: {valor}"); // -35
            valor = +valor;
            Console.WriteLine($"Valor en este momento: {valor}"); // -35
            valor = -valor;
            Console.WriteLine($"Valor en este momento: {valor}"); // 35
        }
    }
}
