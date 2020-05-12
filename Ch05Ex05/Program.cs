using static System.Console;

namespace Ch05Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            // var
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle", null, "" };
            
            // Loop through the friendNames array and check for several cases and inform the relevant info for the current value in the loop
            foreach (var friendName in friendNames)
            {

                switch (friendName)
                {
                    case string t when t.StartsWith("T"):
                        WriteLine("This friends name starts with a 'T': " +
                        $"{friendName} and is {t.Length - 1} letters long ");
                        break;
                    case string e when e.Length == 0:
                        WriteLine("There is a string in the array with no value");
                        break;
                    case null:
                        WriteLine("There was a 'null' value in the array");
                        break;
                    case var x:
                        WriteLine($"This is the var pattern of type: {x.GetType().Name}");
                        break;
                }
            }

            // vars
            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };

            // Loop through each integer in the array, keep a total amount of looped through integers in the array
            foreach (var integer in myIntArray)
            {
                switch (integer)
                {
                    case 0:
                        total++;
                        WriteLine($"Integer number '{ total }' has a default value of 0");
                        break;
                    case int value:
                        // Add to the total amount of integers that are != null or > 0
                        counter++;
                        total++;
                        sum += value;
                        WriteLine($"Integer number '{ total }' has a value of {value}");                      
                        break;
                    case null:
                        total++;
                        WriteLine($"Integer number '{ total }' is null");
                        break;
                }
            }

            // Show the result
            WriteLine($"{total} total integers, {counter} integers with a value other than 0 or null have a sum value of {sum}");
        }
    }
}
