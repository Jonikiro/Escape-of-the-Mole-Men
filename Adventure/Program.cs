/*An adventure game by Matthew Cabrera
* Development began March 15, 2018
*
* This work is a derivative of
* "C# Adventure Game" by http:// Progammingisfun.com, used under CC BY.
* https:// creativecommons.org/licenses/by/4.0/
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventure
{
    class Program
    {
        // Main game loop
        static void Main()
        {
            // Sets the window title to name of the game.
            Console.Title = "Escape of the Mole Men";

            // Initiates main menu
            MainMenu();

            Console.ReadKey();
        }

        // Main Menu Functionality
        public static void MainMenu()
        {
            // Main Menu Dialog
            while (true)
            {
                Console.Clear();
                Console.Write("Welcome to \"Escape of the Mole Men.\"" +
                   "\nWould you like to start a new game or continue from a previous save?\n" +
                   "\n1. New Game" +
                   "\n2. Continue\n\n" +
                   "Type a number to make your decision: ");

                // Saves choice as string variable, normalizes content
                string gameChoice = Console.ReadLine().Replace(" ", "");

                // Starts new game or loads up recent checkpoint using code from Save.txt
                if (gameChoice == "1")
                {
                    Console.Clear();
                    Intro.IntroMain();
                    break;
                }
                else if (gameChoice == "2")
                {
                    Console.Clear();
                    Load(@"D:\C#\Adventure\Adventure\Save.txt");
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        // Allows the user to continue at their own pace.
        public static void Cont()
        {
            Console.WriteLine("\n\nPress the spacebar to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar)
                continue;
            Console.Clear();
        }

        // Allows for customizable text
        public static void Dialog(string message, string color)
        {
            switch (color)
            {
                case "dr":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dg":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "db":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dy":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "r":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "g":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "b":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "y":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "p":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "c":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "w":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "x":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }

            Console.Write(message);
            Console.ResetColor();
        }

        // Code for user input and response
        public static string Action(string message, string[] action)
        {
            string choice;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            choice = Console.ReadLine().ToUpper().Replace(" ", "");

            if (!action.Contains(choice))
                return "NULL";

            Console.Clear();
            Console.ResetColor();

            return choice;
        }

        // Creates new checkpoint
        public static void Save(string code)
        {
            File.WriteAllText(@"D:\C#\Adventure\Adventure\Save.txt", code);
        }

        // Reads checkpoint code from save file and loads respective scene
        private static void Load(string path)
        {
            string code = File.ReadAllText(@path);

            // Switch statement contains "table of contents" for story to load from
            switch (code)
            {
                case "1":
                    Intro.IntroMain();
                    break;
                case "2":
                    Intro.IntroPart2();
                    break;
            }
        }
    }
}
