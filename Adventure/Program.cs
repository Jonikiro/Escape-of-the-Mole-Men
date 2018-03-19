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
            Game.Introduction();
            Console.ReadKey();
        }
    }

    public static class Game
    {
        static string charName = "John Doe";

        public static void Introduction()
        {
            Console.Title = "Text Adventure";
            Console.WriteLine("(Type \"LIGHT\" to turn your flashlight on) ");
            while (Console.ReadLine().ToUpper() != "LIGHT")
            {
                Console.Clear();
                Console.WriteLine("(Type \"LIGHT\" to turn your flashlight on) ", "w");
            }
            Console.Clear();
            Dialog("You breathe a sigh of relief as a beam of light cuts through the darkness.\n" +
                "Tonight's desperate plan will be hard enough as it is, but it would be just\n" +
                "your luck if something went wrong right out of the gate.", "w");
            Dialog("\"Hey Frankie, did you see something over there?\"", "red");
            Dialog("Shit.", "w");
        }

        static void Cont()
        {
            Console.WriteLine("\nPress the spacebar to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar)
                continue;
            Console.Clear();
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
            Cont();
        }

        static void Choice()
        {
            string input = "";
            Console.WriteLine(charName + ", which will you choose? A or B?");
            input = Console.ReadLine().ToUpper();
            if (input == "A")
            {
                Console.WriteLine("You've chosen path A!");
            }
            else
            {
                Console.WriteLine("You've chosen path B!");
            }
        }
    }

    class Items
    {

    }
}
