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

namespace Adventure
{
    class Program
    {
        // Main game loop
        static void Main()
        {
            Intro.IntroMain();
            Console.ReadKey();
        }

        // Allows the user to continue at their own pace.
        public static void Cont()
        {
            Console.WriteLine("\nPress the spacebar to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Spacebar)
                continue;
            Console.Clear();
        }

        // Allows for customizable text to differentiate actors.
        public static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (color == "purple")
            { Console.ForegroundColor = ConsoleColor.Magenta; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
            Cont();
        }

        // Code for user input and response
        public static void Action(string message, string action)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            while (Console.ReadLine().ToUpper().Replace(" ", "") != action)
            {
                Console.Clear();
                Console.Write(message);
            }
            Console.Clear();
            Console.ResetColor();
        }
    }
}
