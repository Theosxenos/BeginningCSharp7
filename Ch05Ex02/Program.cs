using System;
using static System.Console;

namespace Ch05Ex02
{
    /// <summary>
    /// Orientation
    /// </summary>
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Vars
            byte directionByte;
            string directionString;

            // Set the orientation and output it
            orientation myDirection = orientation.north;
            WriteLine($"myDirection = {myDirection}");

            // Convert the enum to byte and string and output both
            directionByte = (byte)myDirection;
            directionString = Convert.ToString(myDirection);
            WriteLine($"byte equivalent = {directionByte}");
            WriteLine($"string equivalent = {directionString}");
        }
    }
}
