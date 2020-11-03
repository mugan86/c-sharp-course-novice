using System;
using System.Collections.Generic;

namespace StrangleGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Game gameObject = new Game();
            // gameObject.draw(5);
        }
    }

    public class Game
    {
        public int Attemps
        { get; set; }
        public string HideWord { get; set; }
        public string GameWordsChars { get; set; }
        public List<char> InputCharsList { get; set; }
        // https://docs.microsoft.com/es-es/dotnet/api/system.string.tochararray?view=netcore-3.1
        public char[] HideWordChars { get; set; }
        // Teniendo en cuenta la palabra correcta, se almacena la información correcta
        public List<char> CorrectChars { get; set; }
        public Game()
        {
            Attemps = 6;
            HideWord = "Anartz Mugika";
            HideWordChars = (HideWord.ToLower()).ToCharArray();
            GameWordsChars = "";
            Console.WriteLine(HideWordChars.Length);
            // Tenemos almacenados todos los carácteres si existe
            CorrectChars = new List<char>(HideWordChars);
            InputCharsList = new List<char>();
            for (int i = 0; i < HideWordChars.Length; i++)
            {

                if (HideWordChars[i] != ' ')
                {
                    GameWordsChars += "_ ";
                    HideWordChars[i] = '_';

                }
                else
                {
                    GameWordsChars += "....";
                }
            }
            Console.WriteLine(GameWordsChars);
            Play();
        }

        private void Play()
        {
            while (Attemps >= 6)
            {
                Console.Write("Introduzca letra: ");
                char inputChar = Console.ReadLine()[0];
                // Comprobar si 
                Console.WriteLine("Introducido " + inputChar);
                if (!InputCharsList.Contains(inputChar))
                {
                    InputCharsList.Add(inputChar);
                    // Hacer jugada y mirar si existe en la palabra
                    CheckExisteCharInWord(inputChar);
                    DrawHideWord();
                }
                else
                {
                    Console.WriteLine("Ya existe");
                }
                

            }
        }
        private void CheckExisteCharInWord(char inputChar)
        {
            if (CorrectChars.Contains(inputChar))
            {
                Console.WriteLine("Encontrado en la palabra, vamos a sustituir donde haya en el HideWordChars");
                for (int i = 0; i < HideWordChars.Length; i++)
                {
                    if (CorrectChars[i] == inputChar)
                    {
                        HideWordChars[i] = inputChar;
                    }
                }
            }
        }
        private void DrawHideWord()
        {
            GameWordsChars = "";
            for (int i = 0; i < HideWordChars.Length; i++)
            {
                if (HideWordChars[i] == '_') {
                    GameWordsChars += "_ ";
                } else {
                    GameWordsChars += HideWordChars[i];
                }
                
            }
            Console.WriteLine(GameWordsChars);
        }
        public void draw(int i)
        {
            switch (i)
            {
                case 6:
                    Console.WriteLine(" ---------------------");
                    for (int j = 0; j <= 15; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    break;

                case 5:
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                 | -  -  |");
                    Console.WriteLine(" |                 |   o   |");
                    Console.WriteLine(" |                  -------");
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    break;

                case 4:
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                 | -  -  |");
                    Console.WriteLine(" |                 |   o   |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                     |   ");
                    for (int j = 0; j <= 5; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    break;

                case 3:
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                 | -  -  |");
                    Console.WriteLine(" |                 |   o   |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                   / |   ");
                    Console.WriteLine(" |                 /   |   ");
                    Console.WriteLine(" |                /    |   ");
                    Console.WriteLine(" |                     |   ");
                    for (int j = 0; j <= 5; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    break;

                case 2:
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                 | -  -  |");
                    Console.WriteLine(" |                 |   o   |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                   / | \\ ");
                    Console.WriteLine(" |                  /  |   \\ ");
                    Console.WriteLine(" |                 /   |     \\ ");
                    Console.WriteLine(" |                     |   ");
                    for (int j = 0; j <= 5; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    break;

                case 1:
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                 | -  -  |");
                    Console.WriteLine(" |                 |   o   |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                   / | \\ ");
                    Console.WriteLine(" |                  /  |   \\ ");
                    Console.WriteLine(" |                 /   |     \\ ");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                    /  ");
                    Console.WriteLine(" |                   /      ");
                    Console.WriteLine(" |                  /       ");
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    break;

                case 0:
                    Console.WriteLine(" ---------------------");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                     |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                 | X  X  |");
                    Console.WriteLine(" |                 |   o   |");
                    Console.WriteLine(" |                  -------");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                   / | \\ ");
                    Console.WriteLine(" |                  /  |   \\ ");
                    Console.WriteLine(" |                 /   |     \\ ");
                    Console.WriteLine(" |                     |   ");
                    Console.WriteLine(" |                    / \\");
                    Console.WriteLine(" |                   /   \\  ");
                    Console.WriteLine(" |                  /     \\ ");
                    for (int j = 0; j <= 2; j++)
                    {
                        Console.WriteLine(" |");

                    }
                    Console.WriteLine("__________");
                    Console.WriteLine("GAME OVER");
                    break;
            }
        }
    }




    /*
    /**
     * @author Luis Created on 28/08/2014, 11:18:58 PM

    public class AhorcadoNormal {

        public static void main(String[] args) {
            Scanner s = new Scanner(System.in);
            int vidas = 6;
            String palabra;
            int aciertos = 0;
            int tamaño;
            String opcion;
            int contador = 0;
            String[] palabras = new String[]{"lapiz", "goma", "libreta", "maestro", "examen", "matematicas"};
            char[] respuesta;
            palabra = palabras[(int) (Math.random() * 5)];
            tamaño = palabra.length();
            respuesta = new char[tamaño];


            for (int i = 0; i <= tamaño; i++) {
                respuesta[i] = 'X';
            }


            while (aciertos != tamaño &amp;&amp; vidas != 0) {
                Console.WriteLine("=========AHORCADO :)==========          VIDAS="+vidas +" Aciertos= "+aciertos);
                dibujar(vidas);
                Console.WriteLine("");
                for (int i = 0; i <= tamaño; i++) {

                    System.out.print("__" + respuesta[i] + "___  ");
                }
                Console.WriteLine("\nIngresa una letra: ");
                opcion = s.next();
                if (palabra.contains(opcion)) {
                    for (int i = 0; i <= tamaño; i++) {
                        if (palabra.charAt(i) == opcion.charAt(0)) {
                            respuesta[i] = opcion.charAt(0);
                            contador++;
                        }
                    }

                    aciertos = aciertos + contador;
                } else {
                    vidas--;
                }

                contador = 0;
            }
            if(vidas==0){
                dibujar(vidas);
            }else
            {
                Console.WriteLine("");
                for (int i = 0; i <= tamaño; i++) {

                    System.out.print("__" + respuesta[i] + "___  ");
                }
                Console.WriteLine("YOU WIN :)");

            }
        }

    }
    */
}
