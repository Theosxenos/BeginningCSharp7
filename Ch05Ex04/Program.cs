using static System.Console;

namespace Ch05Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vars
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            int i;

            // Show the names of the friends
            WriteLine($"Here are {friendNames.Length} of my friends:");
            foreach (string friendName in friendNames)
            {
                WriteLine(friendName);
            }
        }
    }
}
