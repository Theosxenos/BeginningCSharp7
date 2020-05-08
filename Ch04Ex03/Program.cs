using System;
using static System.Console;

namespace Ch04Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            const string myName = "benjamin";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;

            // Ask for name
            WriteLine("What is your name?");
            name = ReadLine();

            // Compare answered name with pre-defined names
            switch (name.ToLower())
            {
                case myName:
                    WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That's a very silly name.");
                    break;
                default:
                    WriteLine($"Hello {name}!");
                    break;
            }           
        }
    }
}
