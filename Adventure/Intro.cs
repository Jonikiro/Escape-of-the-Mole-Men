using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public static class Intro
    {
        public static void IntroMain()
        {
            // Sets the window title to name of the game.
            Console.Title = "Escape of the Mole Men";

            // Initiates first action of the game
            Console.WriteLine("(Type \"LIGHT\" to turn your flashlight on) ");
            while (Console.ReadLine().ToUpper() != "LIGHT")
            {
                Console.Clear();
                Console.WriteLine("(Type \"LIGHT\" to turn your flashlight on) ", "w");
            }
            Console.Clear();

            // Dialog 1
            Program.Dialog("You breathe a sigh of relief as a beam of light cuts through the darkness.\n" +
                "Tonight's desperate plan will be hard enough as it is, but it would be just\n" +
                "your luck if something went wrong right out of the gate.", "w");
            Program.Dialog("\"Hey Frankie, did you see something over there?\"", "red");
            Program.Dialog("Shit.", "w");


        }
    }
}
