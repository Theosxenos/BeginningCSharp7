using static System.Console;

namespace Exer5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            string userInput;
            string editedString;

            // Ask the user for a word
            WriteLine("Please write a word:");
            userInput = ReadLine();

            // Replace all no, with yes
            editedString = userInput.Replace("no", "yes");
            WriteLine($"{editedString}");

        }
    }
}
