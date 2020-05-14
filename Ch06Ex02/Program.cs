using static System.Console;

namespace Ch06Ex02
{
    class Program
    {
        /// <summary>
        /// Gets the highest number from an array
        /// </summary>
        /// <param name="intArray">An array with numbers</param>
        /// <returns>An integer of the highest number</returns>
        static int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }

        static void Main(string[] args)
        {
            // var
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            // Call the function and show the result
            int maxVal = MaxValue(myArray);
            WriteLine($"The maximum value in myArray is {maxVal}");
        }
    }
}
