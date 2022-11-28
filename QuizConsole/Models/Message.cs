using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizConsole.Models
{
    // klasa ospowiadająca za wyświetlanie komunikatów graczowi
    internal class Message
    {
        public void DisplayGameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Niestety, ale to nie jest dobra odpowiedź.");
            Console.WriteLine("KONIEC GRY");
        }

        // wyświetlanie powitania
        internal void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("* WITAMY W NASZYM QUIZIE *");
            Console.WriteLine("**************************");
            Console.WriteLine("** Odpowiedz na 7 pytań **");
            Console.WriteLine("**************************");
            Console.WriteLine("***** POWODZENIA !!! *****");
            Console.WriteLine();
            Console.WriteLine("Nacisnij ENTER aby rozpocząć grę ...");
            Console.ReadLine();
            Console.Clear();
        }


        public void GoodAnswerMessage()
        {
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Brawo to prawidłowa odpowiedź !!!");
            Console.WriteLine();
            Console.Write("Nacisnij ENTER aby zobaczyć następne pytanie ...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void FinalScreen()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Brawo, udało CI się ukończyć quiz !!!!");
            Console.WriteLine();
        }
    }
}
