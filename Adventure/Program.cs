﻿/*An adventure game by Matthew Cabrera
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

        // Allows for customizable text
        public static void CustomText(string message, string color)
        {
            switch (color)
            {
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
