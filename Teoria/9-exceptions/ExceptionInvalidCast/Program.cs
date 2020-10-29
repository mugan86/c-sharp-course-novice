using System;

namespace ExceptionInvalidCast
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int valueInt = Convert.ToInt32(true);
                Console.WriteLine(Convert.ToChar(valueInt + 50));
            } catch(InvalidCastException ice) {
                Console.WriteLine("Casting Incorrecto: {0}", ice.Message);
            }catch (Exception ex) {
                Console.WriteLine("Excepción general {0}", ex);
            } finally {
                Console.WriteLine("Programa finalizado con todo ejecutado");
            }
        }
    }
}
