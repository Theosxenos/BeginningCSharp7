using System;
using static System.Console;
using static System.Convert;

namespace Exer4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 0, var2 = 0;

            do
            {
                WriteLine("Give me a number:");
                var1 = ToInt32(ReadLine());

                WriteLine("Give me another number:");
                var2 = ToInt32(ReadLine());

            } while (!(var1 > 10 ^ var2 > 10));

            WriteLine($"{var1 > 10 ^ var2 > 10}");
        }
    }
}
