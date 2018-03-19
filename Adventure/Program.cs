/*An adventure game by Matthew Cabrera
* Development began March 15, 2018
*
* This work is a derivative of
* "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
* https://creativecommons.org/licenses/by/4.0/
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
        //Main game loop
        static void Main()
        {
            Game.Intro();
            Console.ReadKey();
        }
    }
}
