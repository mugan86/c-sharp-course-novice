using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
		 Convertidor Euros-Pesetas Españolas.
     Vamos a crear en C# un programa, donde tenemos  que realizar la siguiente conversión.
     Convertir una cantidad de euros en pesetas.
     Sabiendo que  1 euro = 166,386 pesetas españolas.
     Ejemplo:
     Euros-> Pesetas = 16 euros son 2.662,176 pesetas españolas
     Pesetas->Euros=100000 pesetas españolas son 601,0121euros
		*/
            Console.WriteLine("Introduzca la cantidad de euros que quieres convertir en pesetas españolas:");
            double inputEuros = Convert.ToDouble(Console.ReadLine());
            /**
            Una vez que hemos introducido la cantidad en pesetas, lo convertimos en euros haciendo:
            pesetas / 166.386 = resultado
            **/

            double conversionPtasEuros = inputEuros * 166.386;
            Console.WriteLine($"La cantidad de pesetas que tiene {inputEuros} ptas es {conversionPtasEuros} pesetas.");
        }
    }
}
