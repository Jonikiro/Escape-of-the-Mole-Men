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
            Program.Save("1");
            string introChoice;

            // Dialog
            Program.Dialog("\"Quiet...\"", "dg");
            Program.Cont();
            Program.Dialog("\"Did you hear that, sis?\"", "dg");
            Program.Cont();
            Program.Dialog("You strain to listen in the darkness. Sound travels far down in the sewers, but\n" +
                "you've long gotten used to the usual culprits. Rats skittering along concrete\n" +
                "walls, bilge water seeping down from countless tunnels, and the quiet, distant\n" +
                "roar of civilization above.", "w");
            Program.Cont();
            Program.Dialog("Still, your brother's right. Below the noise, there's something...new.", "w");
            Program.Cont();

            // Choice
            string[] introDialog1 = { "1", "2", "3" };

            do
            {
                Console.Clear();
                Program.Dialog("You turn to him and whisper:\n\n", "w");
                Program.Dialog("1. We should check it out.\n", "y");
                Program.Dialog("2. What do you think it is?\n", "w");
                Program.Dialog("3. Where do you think it's coming from?\n", "w");
                introChoice = Program.Action("\nChoose a dialog option: ", introDialog1);

                if (introChoice == "2")
                {
                    Program.Dialog("I can't quite make it out. What's your take?", "w");
                    Program.Cont();
                }
                else if (introChoice == "3")
                {
                    Program.Dialog("I didn't see anything weird on our way here. Where do you think it is?", "w");
                    Program.Cont();
                }

            } while (introChoice != "1");

            Program.Dialog("Whatever it is, we need to take care of it now so it doesn't\n" +
                "follow us home. Let's go.", "w");
            Program.Cont();

            Program.Save("2");
            IntroPart2();
        }

        public static void IntroPart2()
        {
            Program.Dialog("Part 2...", "r");
            Program.Cont();
        }
    }
}
