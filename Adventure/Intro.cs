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
            Program.Action("(Type \"LIGHT\" to turn your flashlight on)\n\nEnter your command: ", "LIGHT");

            // Intro Dialog 1
            Program.Dialog("You breathe a sigh of relief as a beam of light cuts through the darkness.\n" +
                "Getting your electronics from the Vegas City Dump had always been a crapshoot, \n" +
                "but if tonight went smoothly, you'd never have to go back there again.", "w");

            // Intro Action 1
            Program.Action("Now to get a good look at this place and SHINE your light ahead.\n\nEnter your command: ", "SHINE");

            // Intro Dialog 2
            Program.Dialog("You pass the light over the building in front of you and see...\n" +
                "A real dump. Graffiti on the piss-stained brick walls, shattered glass behind\n" +
                "window bars. No indication that this abandoned apartment was anything more than\n" +
                "a squatter's' den.", "w");
            Program.Dialog("Nothing, except that Two-Tooth Tom swore he saw a convoy of real sharp-\n" +
                "looking government types wheeling a bunch of fancy equipment into the building.\n" +
                "That meant something valuable was in there.", "w");

            // Intro Action 3
            Program.Action("\"Time to go to work,\" you say, pulling out your LOCKPICK set.\n\nEnter your command: ", "LOCKPICK");

            // Intro Dialog 4
            Program.Dialog("END OF CURRENT VERSION", "w");
        }
    }
}
