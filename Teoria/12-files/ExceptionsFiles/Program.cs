using System;
using System.IO;

namespace ExceptionsFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileElement;
            try {
                // Vamos a leer el fichero
                // Carga fichero de ruta seleccionada
                fileElement = File.OpenText("5-countries.txt");
                string line = "";
                do {
                    line = fileElement.ReadLine();
                    if (line != null) {
                        Console.WriteLine(line);
                    }
                } while (line != null);

            } catch (PathTooLongException) {
                Console.WriteLine("El path o ruta de este fichero es demasiado largo. Procura añadir un path más corto");
            } catch (FileNotFoundException) {
                Console.WriteLine("El fichero seleccionado no es correcto por no encontrarse en la ruta especifada");
            } catch (Exception exc) {
                Console.WriteLine("Excepción: {0}", exc.Message);
            }
        }
    }
}
