using System;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
                Introduzca la lista de la compra con los precios de 5 productos (donde recogemos por teclado el precio que puede tener decimales en cada caso). Le aplicaremos el total de lo que gastaremos y le aplicamos el IVA del 21%.
            Mostrar por consola el resumen de todos los productos con sus respectivos precios, el total de lo que hemos gastado y el total con el IVA (21%).


                */
            Console.WriteLine("Introduce el primer producto");
            double productOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el segundo producto");
            double productTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el tercer producto");
            double productThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el cuarto producto");
            double productFour = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce el quinto producto");
            double productFive = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("==============Resumen de los gastos realizados==============");

            double totalWithoutIva = productOne + productTwo + productThree + productFour + productFive;
            double totalWithIva = totalWithoutIva + (totalWithoutIva * 0.21);
            // Resultado
            Console.WriteLine($"Total gastado sin IVA: {totalWithoutIva}");
            Console.WriteLine($"Total gastado con IVA (21%): {totalWithIva}");

        }
    }
}
