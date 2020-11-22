using System;
using System.Collections.Generic;
using System.IO;

namespace StrangleGame
{
    class Game
    {
        // Vamos a añadir las propiedades del juego ahorcado
        // Intentos necesarios
        public int Attemps { get; set; } // Por defecto 6
        // Palabra secreta
        public string HideWord { get; set; }
        // Palabra oculta "encriptada"
        public string GameWordChardsShow { get; set; }

        // Listas para el flujo del juego
        public List<char> InputCharsList { get; set; }
        public List<char> HideWordChars { get; set; } // se almacenan por defecto así => "_"
        public List<char> CorrectChars { get; set; } // anartz => 'a', 'n', 'a', 'r', 't', 'z'
        public Game() {
            // Intentos por defecto 6
            Attemps = 6;
            // Añadimos palabra oculta fija
            HideWord = GetHideWord();
            // Convertir el string en un array de carácteres para aplicar las listas necesarias
            char [] charListElements = (HideWord.ToLower()).ToCharArray();

            // Inicializar lista para los carácteres que vamos introduciendo
            InputCharsList = new List<char>();

            HideWordChars = new List<char>(charListElements);

            CorrectChars = new List<char>(charListElements);

            for(int i = 0; i < HideWordChars.Count; i++) {
                if (HideWordChars[i] != ' ') {
                    HideWordChars[i] = '_';
                    GameWordChardsShow += "_ ";
                } else {
                    GameWordChardsShow += "  ";
                }
            }
            Draw.Image(Attemps, HideWord);
            Draw.HideWord(GameWordChardsShow);
        }
        public void Play() {
            // Mientras jugamos
            while(Attemps > 0 && HideWordChars.Contains('_')) {
                // Introducir el carácter desde la consola con el teclado
                char inputChar = ' ';
                Console.Write("\nIntroduzca la letra: ");
                try {
                    inputChar = Console.ReadLine().ToLower() [0];
                } catch(IndexOutOfRangeException) {
                    Console.WriteLine("Debes de añadir algo de información");
                    inputChar = '.';
                } catch (Exception e) {
                    Console.WriteLine("Error general {0}", e);
                }

                // Conprobar que es un carácter válido
                if (inputChar >= 'a' && inputChar <= 'z') {
                    // Comprobar si ese caracter se ha introducido
                    if (!InputCharsList.Contains(inputChar)) {
                        Console.Clear();
                        // Añadir para no repetir caracteres
                        InputCharsList.Add(inputChar);
                        // Comprobar si existe en la palabra oculta
                        CheckExistCharInWord(inputChar);
                        // Dibujar el estado dependiendo del resultado dado en la comprobación
                        Draw.Image(Attemps, HideWord);
                        Draw.HideWord(GameWordChardsShow);
                    } else {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Ya has introducido el caracter '{0}'. Prueba de nuevo por favor con otro caracter", inputChar);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            // Partida finalizada
            if (Attemps == 0) {
                Draw.Image(Attemps, HideWord);
            } else if (!HideWordChars.Contains('_')) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enhorabuena, has ganado");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        private string GetHideWord() {
            List<string> hideWords = LoadWordChars();
            Random random = new Random();
            int numberRandom = random.Next(0, hideWords.Count);
            return hideWords[numberRandom];
        }
        private List<string> LoadWordChars () {
            string loadtText = File.ReadAllText(@"data/sagas-miticas.txt");

            string [] words = loadtText.Split("\n");
            return new List<string>(words);
        }
        private void CheckExistCharInWord(char inputChar) {
            // Comprobar que existe dentro de CorrectChars
            if (CorrectChars.Contains(inputChar)) {
                // Hemos acertado
                GameWordChardsShow = "";
                Console.WriteLine("Has acertado :).");
                for(int i = 0; i < HideWordChars.Count; i++) {
                    if (CorrectChars[i] == inputChar) {
                        HideWordChars[i] = inputChar;
                    }
                    GameWordChardsShow += (HideWordChars[i] != ' ') ? HideWordChars[i] + " ": "   "; 
                }
            } else {
                // NO hemos acertado
                Attemps--;
                Console.WriteLine("No has acertadp, lo siento :(");
            }
        }
        
    }
}
