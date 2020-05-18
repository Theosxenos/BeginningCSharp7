using System;
using System.Diagnostics;
using static System.Console;

namespace Exer7._4
{
    class Program
    {
        enum Orientation : byte
        {
            North = 1,
            South = 2,
            East = 3,
            West = 4
        }
        static void Main(string[] args)
        {
            byte byteOrientationCorrect = 1;
            int byteOrientationWrong = 335;
            Orientation orientation;

            try
            {
                WriteLine("Trying correct byte orientation");
                Debug.WriteLine("Trying correct byte orientation");
                orientation = checked((Orientation)(byteOrientationCorrect));

                WriteLine("Trying wrong byte orientation");
                Debug.WriteLine("Trying wrong byte orientation");
                orientation = checked((Orientation)(byteOrientationWrong));
            }
            catch (OverflowException e)
            {
                Debug.WriteLine(e);
                WriteLine("Failed succesfully!");
            }

        }
    }
}
