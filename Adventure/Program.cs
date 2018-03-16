/*An adventure game by Matthew Cabrera
* Development began March 15, 2018
*
* This work is a derivative of
* "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
* https://creativecommons.org/licenses/by/4.0/
*/

using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }

    public static class Game
    {
        static string charName = "John Doe";

        public static void StartGame()
        {
            Console.Title = "Adventure Game";
            Console.WriteLine("Matt's Adventure Game!");
            Dialog("Welcome to the magical realm of Daz!");
            NameCharacter();
        }
        
        static void NameCharacter()
        {
            Dialog("What is your name, traveler? ");
            charName = Console.ReadLine();
            Dialog("Dare you enter my magical realm, " + charName + "?");
        }

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    class Items
    {

    }
}
