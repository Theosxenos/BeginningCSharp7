using System;
using static System.Console;
using static System.Convert;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for a number and convert into int
            WriteLine("Enter an integer:");
            int myInt = ToInt32(ReadLine());
            // Check the number for smaller than 10 or between 0 and 5
            bool isLessThan10 = myInt < 10; 
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            // Show the results
            WriteLine($"Integer less than 10? {isLessThan10}");
            WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            // Check for exclusive true
            WriteLine($"Exactly one of the above is true? {isLessThan10 ^ isBetween0And5}");
        }
    }
}
