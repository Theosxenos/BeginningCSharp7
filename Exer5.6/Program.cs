using System;
using static System.Console;

namespace Exer5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            string userInput;
            string[] userInputSplit;

            // Ask user for a sentence:
            WriteLine("Please write a sentence:");
            userInput = ReadLine();

            // Split the sentence on whitespaces, so it turns into an array with words
            userInputSplit = userInput.Split();

            WriteLine("Your sentence with quoted words:");
            // Loop through all the words, append the double quotes, and a trailing whitespace
            for (int i = 0; i < userInputSplit.Length; i++)
            {
                Console.Write($"\"{userInputSplit[i]}\" ");
            }
            WriteLine();
        }
    }
}
