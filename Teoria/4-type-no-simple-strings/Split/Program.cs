using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterVideoGames = "Mario/Luigi/Sack Boy/Lara Corft/Solid Snake/Sonic";
            string [] charactersList = characterVideoGames.Split('/');
            // Coger string con varios caracteres separando
            string message = "¡Hola Anartz! ¿Qué tal estás? (Espero que todo bien.)";
            char [] separatorList = {'¡', '¿', '('};
            string [] messageList = message.Split(separatorList);
        }
    }
}
