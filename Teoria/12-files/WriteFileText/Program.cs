using System;
using System.IO;
namespace WriteFileText
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fileManage;

            // Asignar lo que es l fichero creado en el flujo
            fileManage = File.CreateText("1-mario-saga.txt");
            fileManage.WriteLine("=======MARIO GAMES SAGA=======");
            fileManage.WriteLine("Super Mario Land 2");
            fileManage.WriteLine("Super Mario Galaxy");
            fileManage.WriteLine("Super Mario World 2");
            fileManage.Write("Super Mario Bros 3");
            fileManage.Close();
        }
    }
}
