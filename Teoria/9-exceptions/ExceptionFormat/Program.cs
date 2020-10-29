using System;

namespace ExceptionFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                string numberValue = "truee";
                bool numberBoolean = Convert.ToBoolean(numberValue);
                Console.WriteLine("El número es {0}", numberBoolean);
            } catch (FormatException fEx) {
                Console.WriteLine("Error formato: {0}", fEx.Message);
            } 
            catch (Exception fEx) {
                Console.WriteLine("Error formato: {0}", fEx.Message);
            } finally {
                Console.WriteLine("Final del programa");
            }
        }
    }
}
