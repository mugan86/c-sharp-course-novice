using System;

namespace Exercise
{
    class Program
    {
        // Dado un array de numeros con el metodo Sort, 
        //ordenalos y muestra su contenido.
        static void Main(string[] args)
        {
 
            int [] valuesList = {1, 4, 56, 6, 7};
            Console.WriteLine("Valores originales:");
            foreach(int item in valuesList) {
                Console.WriteLine(item);
            }
            // Volteamos la información de la lista inicial
            int [] valuesReverseList = new int[valuesList.Length];
            Console.WriteLine("Valores revertidos:");
            int listLength = valuesList.Length;
            for(int i = 0; i < listLength; i++) {
                int item = valuesList[i];
                valuesReverseList[(listLength -1) - i] = item;
            }
            valuesList = valuesReverseList;
            foreach(int item in valuesList) {
                Console.WriteLine(item);
            }
        }
    }
}
