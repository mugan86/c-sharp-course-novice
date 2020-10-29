using System;

namespace ExceptionDivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1234, numberTwo = 0;
            try {
                numberOne = 8292;
                Console.WriteLine(" División {0}", numberOne / numberTwo);
            } catch (DivideByZeroException ex) {
                Console.WriteLine("{0} no se puede dividir con 0", numberOne);
                Console.WriteLine("Error info: {0}", ex.Message);
            } catch (Exception ex) {
                Console.WriteLine("Excepción generada {0}", ex);
            } finally {
                Console.WriteLine("Final con el programa dividir por cero");
            }
        }
    }
}
