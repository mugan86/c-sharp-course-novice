using System;
using System.IO;

namespace FileExists
{
    class Program
    {
        static void Main(string[] args)
        {
            // string curFile = @"../../../data/1-mario-saga-game.txt";
            string curFile = @"/Users/anartz/Desktop/curso_c#/data/6-tomb-raider-saga-games.txt";
            Console.WriteLine(File.Exists(curFile) ? "Fichero existe." : "Fichero no existe.");
        }
    }
}
