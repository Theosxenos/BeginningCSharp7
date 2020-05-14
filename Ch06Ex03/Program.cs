using static System.Console;

namespace Ch06Ex03
{
    class Program
    {
        /// <summary>
        /// Addup all the input numbers
        /// </summary>
        /// <param name="vals">The numbers to addup</param>
        /// <returns>A sum of all the numbers</returns>
        static int SumVals(params int[] vals)
        {
            int sum = 0;
            foreach (int val in vals)
            {
                sum += val;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            // Call the function and output the result
            int sum = SumVals(1, 5, 2, 9, 8);
            WriteLine($"Summed Values = {sum}");
        }
    }
}
