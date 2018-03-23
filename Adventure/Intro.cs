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
            Console.WriteLine("This is the start of the story.");
            Program.Save("2");
            Program.Cont();
            IntroPart2();
        }

        public static void IntroPart2()
        {
            Console.WriteLine("This is the middle.");
        }
    }
}
