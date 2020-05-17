using System;
using static System.Console;

namespace Exer6._2
{
    /// <summary>
    /// Write an application that uses two command-line arguments to place values into a string and an integer variable, respectively.Then display those values.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // First argument is string
            string stringArg = "\"" + args[0] + "\"";
            // Second is an int
            int intArg = Convert.ToInt32(args[1]);

            WriteLine($"The string argument is: {stringArg}, and the int argument is: {intArg}");
        }
    }
}
