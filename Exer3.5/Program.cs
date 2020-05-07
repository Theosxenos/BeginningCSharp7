using System;
using static System.Console;

namespace Exer3._5
{
    /// <summary>
    /// Write a console application that obtains four int values from the user and displays the product. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int numberThree;
            int numberFour;

            // Ask for the numbers and convert into int
            WriteLine("Give me a number:");
            numberOne = Convert.ToInt32(ReadLine());
            WriteLine("Give me another number:");
            numberTwo = Convert.ToInt32(ReadLine());
            WriteLine("Give me another number:");
            numberThree = Convert.ToInt32(ReadLine());
            WriteLine("Give me another number:");
            numberFour = Convert.ToInt32(ReadLine());

            // Multiply the numbers and output the answer
            WriteLine($"The product of all your numbers is: {numberOne * numberTwo * numberThree * numberFour}");
        }
    }
}
