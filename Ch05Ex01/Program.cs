using System;
using static System.Console;
using static System.Convert;

namespace Ch05Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;

            // Info text
            WriteLine("Variable Conversion Examples\n");

            // Product of the float and short into the double, and output the result
            doubleResult = floatVal * shortVal;
            WriteLine($"Implicit, -> double: {floatVal} * {shortVal} -> { doubleResult }");

            // Explicitly convert the float to a short, and output the result
            shortResult = (short)floatVal;
            WriteLine($"Explicit, -> short: {floatVal} -> {shortResult}");

            // Explicitly convert the bool and doulbe to a string, and output the result
            stringResult = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
            WriteLine($"Explicit, -> string: \"{boolVal}\" + \"{doubleVal}\" -> {stringResult}");

            // Implicitly convert the integer together with the explicitly converted string, to a long, and output the result
            longResult = integerVal + ToInt64(stringVal);
            WriteLine($"Mixed, -> long: {integerVal} + {stringVal} -> {longResult}");
        }
    }
}
