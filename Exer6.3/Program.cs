using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;

namespace Exer6._3
{
    /// <summary>
    /// Create a delegate and use it to impersonate the ReadLine() function when asking for user input.
    /// </summary>
    class Program
    {
        // Declare delegate
        delegate string ReadLineDelegate();
        // Declare fuction that calls and returns Console.Readline
        static string MyReadLine() => ReadLine();

        static void Main(string[] args)
        {
            // Assign function to delegate
            ReadLineDelegate readline = new ReadLineDelegate(MyReadLine);
            
            // Ask for input and call delegate
            WriteLine("Write something:");
            string input = readline();

            // Show the result
            WriteLine($"You wrote: \"{input}\"");
        }
    }
}
