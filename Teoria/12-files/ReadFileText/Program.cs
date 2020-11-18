using System;
using System.IO;

namespace ReadFileText
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fileRead;

            fileRead = File.OpenText("1-mario-saga-game.txt");
            string line = "";
            do {
                line = fileRead.ReadLine();
                if (line != null) {
                    Console.WriteLine(line);
                }
            }
            while(line != null);
            fileRead.Close();
        }
    }
}
