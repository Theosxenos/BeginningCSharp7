using System;

namespace Exer7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5000; i++)
            {
                Console.WriteLine(i);
                if (i == 5000) throw new Exception("i == 5000");
            }
        }
    }
}
