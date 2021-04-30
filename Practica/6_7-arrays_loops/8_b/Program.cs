using System;

namespace Exercise
{
    class Program
    {
        // Lo mismo que anterior, pero sin usar la función "Sort"
        static void Main(string[] args)  
        {  
            int[] intArray = new int[] {2,9,4,3,5,1,7 };  
            // Valor temporal, donde iremos almacenando 
            // el valor que estamos analizando
            int temp = 0;  
  
            for (int i = 0; i <= intArray.Length-1; i++)  
            {  
                for (int j = i+1; j < intArray.Length; j++)  
                {  
                    if (intArray[i] > intArray[j])  
                    {  
                        temp = intArray[i];  
                        intArray[i] = intArray[j];  
                        intArray[j] = temp;  
                    }  
                }  
            }  
            Console.WriteLine("Ordenar el array de menos a más");  
            int max = intArray[intArray.Length-1];
            int min = intArray[0];
 
            Console.WriteLine("El valor minimo es: "+min);
            Console.WriteLine("El valor maximo es: "+max);
        }  
    }
}
