using System;
using System.Collections.Generic;
using System.IO;  // include the System.IO namespace to use File
namespace StrangleGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game gameObject = new Game();
            gameObject.Play();
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
        public List<char> HideWordChars { get; set; }
        // Teniendo en cuenta la palabra correcta, se almacena la información correcta
        public List<char> CorrectChars { get; set; }
        public Game()
        {
            Attemps = 6;
            HideWord = GetHideWord();
            // Adaptamos en un array de carácteres la palabra secreta
            char[] hideWords = (HideWord.ToLower()).ToCharArray();
            HideWordChars = new List<char>(hideWords);
            GameWordsChars = "";
            Console.WriteLine(HideWordChars.Count);
            // Tenemos almacenados todos los carácteres si existe
            CorrectChars = new List<char>(HideWordChars);
            InputCharsList = new List<char>();
            for (int i = 0; i < HideWordChars.Count; i++)
            {

                if (HideWordChars[i] != ' ')
                {
                    GameWordsChars += "_ ";
                    HideWordChars[i] = '_';

                }
                else
                {
                    GameWordsChars += "    ";
                }
            }
            Console.Clear();
            DrawGameImage();
            Console.WriteLine("Palabra a buscar: ");
            Console.WriteLine(GameWordsChars);
        }

				private string GetHideWord() {
					List<string> hideWords = LoadWords();
					// https://docs.microsoft.com/es-es/dotnet/api/system.random.next?view=netcore-3.1
					Random rnd = new Random();
          return hideWords[rnd.Next(0, hideWords.Count)]; 
				}

				private List<string> LoadWords() {
					 string readText = File.ReadAllText("countries.txt");  // Read the contents of the file
		       string [] words = readText.Split("\n");
	         // Console.WriteLine(words.Length);  // Output the content
					 return new List<string>(words);
				}

        public void Play()
        {
            while (Attemps > 0 && HideWordChars.Contains('_'))
            {

                Console.Write("\nIntroduzca letra: ");

                
                char inputChar;
								try {
                   inputChar = (Console.ReadLine()).ToLower()[0];
									  // Comprobar si 
                   Console.WriteLine("Introducido " + inputChar);
								} catch (IndexOutOfRangeException) {
									Console.WriteLine("Introduzca un carácter que sea entre a y z");
									 inputChar = ' ';
								}

               if ( inputChar >= 'a' && inputChar <= 'z') {
								 if (!InputCharsList.Contains(inputChar) && inputChar != ' ')
                {
                    InputCharsList.Add(inputChar);
                    if (InputCharsList.Count > 0 && inputChar != ' ')
                    {
                        Console.Clear();
                    }
                    // Hacer jugada y mirar si existe en la palabra
                    CheckExisteCharInWord(inputChar);
                    // Comprobar si la palabra ha sido acertada completamente
                    if (HideWordChars.Contains('_') && Attemps > 0)
                    {
                        DrawGameImage();
                        DrawHideWord();
                    }

                } else if (InputCharsList.Contains(inputChar)) {
                    Console.WriteLine("Ya has introducido este carácter");
                }
							 } else {
								 Console.WriteLine("Introduzca un carácter que sea entre a y z");
							 }
                
            }
            if (Attemps == 0) {
                DrawGameImage();
            } else {
                Console.WriteLine("Enhorabuena, has acertado la palabra oculta!!");
            }
        }
        private void CheckExisteCharInWord(char inputChar)
        {
            if (CorrectChars.Contains(inputChar))
            {
                Console.WriteLine("Has acertado :)");
                for (int i = 0; i < HideWordChars.Count; i++)
                {
                    if (CorrectChars[i] == inputChar)
                    {
                        HideWordChars[i] = inputChar;
                    }
                }
                // C
            }
            else
            {
                Attemps--;
                Console.WriteLine("Lo siento, no has acertado :(");
            }
        }
        private void DrawHideWord()
        {
            if (Attemps > 0)
            {
                GameWordsChars = "";
                for (int i = 0; i < HideWordChars.Count; i++)
                {
                    if (HideWordChars[i] == '_')
                    {
                        GameWordsChars += "_ ";
                    }
                    else
                    {
                        GameWordsChars += HideWordChars[i] + " ";
                    }

                }
                Console.WriteLine(GameWordsChars);
            }
            else
            {
                Console.WriteLine($"Partida finalizada. La palabra a acertar era {HideWord}");
            }

        }
        private void DrawGameImage()
        {
            Console.WriteLine("====================");
            Console.WriteLine($"Intentos: {Attemps}");
            Console.WriteLine("====================");
            switch (Attemps)
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
                    Console.WriteLine($"GAME OVER - La palabra a acertar era \"{HideWord}\"");
                    break;
            }
        }
    }
}

