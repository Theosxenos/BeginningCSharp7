using System;

namespace BeginningCSharp7
{
    /// <summary>
    /// Using Simple Type Variables
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadKey();
        }
    }
}
