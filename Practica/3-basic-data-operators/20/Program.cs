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
     Convertir una cantidad de pesetas en euros.
     Sabiendo que  1 euro = 166,386 pesetas españolas.
     Ejemplo:
     Euros-> Pesetas = 16 euros son 2.662,176 pesetas españolas
     Pesetas->Euros=100000 pesetas españolas son 601,0121euros
		*/
            Console.WriteLine("Introduzca la cantidad de pesetas que quieres convertir en euros");
            double inputPesetas = Convert.ToDouble(Console.ReadLine());
            /**
            Una vez que hemos introducido la cantidad en pesetas, lo convertimos en euros haciendo:
            pesetas / 166.386 = resultado
            **/

            double conversionPtasEuros = inputPesetas / 166.386;
            Console.WriteLine($"La cantidad de euros que tiene {inputPesetas} ptas es {conversionPtasEuros} €.");
        }
    }
}
