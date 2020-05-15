using static System.Console;
using static System.Convert;

namespace Ch06Ex05
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;
        static void Main(string[] args)
        {
            ProcessDelegate process;

            // Ask user for input
            WriteLine("Enter 2 numbers separated with a comma:");
            
            // Put the users input in a var
            string input = ReadLine();
            // Get the pos of the comma
            int commaPos = input.IndexOf(',');
            // Take the part before the comma and convert it to a double
            double param1 = ToDouble(input.Substring(0, commaPos));
            // Take the part after the comma and convert it to a double
            double param2 = ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
            
            // Ask the user what to do, depending on choice use the relevant delegate function
            WriteLine("Enter M to multiply or D to divide:");
            input = ReadLine();
            if (input == "M")
                process = new ProcessDelegate(Multiply);
            else
                process = new ProcessDelegate(Divide);
            
            // Out put the result
            WriteLine($"Result: {process(param1, param2)}");
        }
    }
}
