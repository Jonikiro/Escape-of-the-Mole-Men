using System;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            string charName = "John Doe"; 
            Console.WriteLine("Welcome to the magical realm of Daz!");
            Console.Write("What is your name, traveler? ");
            charName = Console.ReadLine();
            Console.WriteLine("Dare you enter my magical realm, " + charName + "?");
            Console.Read();
        }
    }
}
