using static System.Console;

namespace Exer5._4
{
    /// <summary>
    /// Write a console application that accepts a string from the user and outputs a string with the characters in reverse order
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            string userInput;
            string userInputreversed = "";

            // Ask the user for a word
            WriteLine("Please write a word:");
            userInput = ReadLine();

            // Reverse string by iterating from the last char to the first, and show the result          
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                userInputreversed += userInput[i];
            }
            WriteLine($"{userInputreversed}");
        }
    }
}
