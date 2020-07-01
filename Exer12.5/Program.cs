using System;
using System.Linq;

namespace Exer12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = new[] { 1, 2, 3 };
            int[] copy = new int[5];

            tmp.CopyTo(copy, 2);
            var test = tmp.ToList();
            test.Insert(3, 4);

            Console.WriteLine(copy[1]);

            ShortList<int> vs = new ShortList<int>(10)
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8
            };
            vs.Insert(8, 10);

            foreach (var i in vs)
            {
                Console.WriteLine(i);
            }
        }
    }
}
