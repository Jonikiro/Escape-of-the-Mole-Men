using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Adventure
{
    public static class Intro
    {
        // Path for the save game file set up as a field for use within the class
        private static string path = @"D:\C#\Adventure\Adventure\Save.txt";

        public static void IntroMain()
        {
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

            while (true)
            {
                Console.Clear();
                Program.Dialog("You turn to him and whisper:\n\n", "w");
                Program.Dialog("1. We should check it out.\n", "y");
                Program.Dialog("2. Let's keep going.\n", "y");
                Program.Dialog("3. What do you think it is?", "w");
                introChoice = Program.Action("\nChoose a dialog option: ", introDialog1);

                if (introChoice == "3")
                {
                    Program.Dialog("I didn't see anything strange along the way. What do you think it is?", "w");
                    Program.Cont();
                    Program.Dialog("Can't say. You sure we weren't followed? We can't risk leading anyone\n" +
                        "back to our hideout. Not like last time.", "dg");
                    Program.Cont();
                    continue;
                }
                else if (introChoice == "1" || introChoice == "2")
                {
                    break;
                }
            }

            if (introChoice == "1")
            {
                Program.Dialog("Whatever it is, we need to take care of it now so it doesn't\n" +
                "follow us home. Let's go.", "w");
                Program.Save("1");
                Program.Cont();
                IntroPart2A();
            }
            else
            {
                Program.Dialog("Forget it, let's just get back home already.", "w");
                Program.Save("2");
                Program.Cont();
                IntroPart2B();
            }
        }

        public static void IntroPart2A()
        {
            Program.Save("2A");
            Program.Dialog("You come across a Grue and are torn limb from limb", "r");
            Program.Cont();
            Sheets.DB(Sheets.Scopes);
            File.WriteAllText(path, String.Empty);
        }

        public static void IntroPart2B()
        {
            Program.Save("2B");
            Program.Dialog("You find a hidden treasure and never want for anything again.", "g");
            Program.Cont();
            Sheets.DB(Sheets.Scopes);
            File.WriteAllText(path, String.Empty);
        }
    }
}
