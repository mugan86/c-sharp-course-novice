using System;
using System.IO;

namespace AppendTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // HACIENDO USO DE LA CLASE "File"
            StreamWriter fileManage ;

            // Creamos el fichero y añadimos las dos primeras líneas
            fileManage = File.CreateText("2-tomb-raider-saga-games.txt");
            fileManage.WriteLine("=============SAGA TOMB RAIDER=============");
            fileManage.WriteLine("Tomb Raider 2");
            fileManage.Close();

            // Vamos a abrir el fichero existente y añadimos información
            fileManage = File.AppendText("2-tomb-raider-saga-games.txt");
            fileManage.WriteLine("Tomb Raider Anniversary");
            fileManage.Close(); */
            // HACIENDO USO DE LA CLASE "StreamWriter"

            // Creamos el fichero (sobrescribimos también)
            using (StreamWriter sw = new StreamWriter("3-saga-little-planet.txt", false))
            {
                sw.WriteLine("=============== Saga Little Big Planet =================");
                sw.WriteLine("Little Big Planet Karting");
            }

            // Leer el fichero para añadir nueva información
            using (StreamWriter sw = new StreamWriter("3-saga-little-planet.txt", true))
            {
                sw.WriteLine("Little Big Planet 3");
            }
        }
    }
}
