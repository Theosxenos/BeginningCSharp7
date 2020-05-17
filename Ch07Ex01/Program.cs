using System.Diagnostics;
using static System.Console;
using System;

namespace Ch07Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vars
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            // Call the maxima function, with the testArray and an output array as arguments
            int maxVal = Maxima(testArray, out int[] maxValIndices);
            // Output the result of the function
            WriteLine($"Maximum value {maxVal} found at element indices:");
            foreach (int index in maxValIndices)
            {
                WriteLine(index);
            }
        }
        static int Maxima(int[] integers, out int[] indices)
        {
            // Notify debug: function started
            Debug.WriteLine("Maximum value search started.");
            
            indices = new int[1];
            int maxVal = integers[0];
            indices[0] = 0; // At what indices does the maxval occur
            int count = 1; // maxval occurence counter

            // Notify debug: Initialization of index of max value of passed int array
            Debug.WriteLine($"Maximum value initialized to {maxVal}, at element index 0.");

            // Loop through the passed int array
            for (int i = 1; i < integers.Length; i++)
            {
                // Notify debug: Loop status: current index
                Debug.WriteLine($"Now looking at element at index {i}.");

                // If value at current index is bigger than the current maxVal
                if (integers[i] > maxVal)
                {
                    // Set the current value as the new maxVal
                    maxVal = integers[i];
                    count = 1;
                    indices = new int[1];
                    indices[0] = i;
                    // Notify debug: New maximum
                    Debug.WriteLine($"New maximum found. New value is {maxVal}, at element index {i}.");
                }
                // Current value is not bigger than the max
                else
                {
                    // If current value is equal to the maxval
                    if (integers[i] == maxVal)
                    {
                        // Increase the maxval occurence counter
                        count++;

                        /* Book solution:
                        // Store the current indices in a temp. value
                        int[] oldIndices = indices;
                        // Reinitialize the indices array to increase the size to account for the new index
                        indices = new int[count];
                        oldIndices.CopyTo(indices, 0);
                        indices[count - 1] = i;
                        */

                        // Resize the array to account for the new index
                        Array.Resize(ref indices, count);
                        // Assign the new index to the end of the array
                        indices[indices.Length - 1] = i;
                        
                        // Notify debug of duplicate
                        Debug.WriteLine($"Duplicate maximum found at element index {i}.");
                    }
                }
            }
            // Notify debug and release debug
            Trace.WriteLine($"Maximum value {maxVal} found, with {count} occurrences.");
            Debug.WriteLine("Maximum value search completed.");
            
            return maxVal;
        }
    }
}