using System;
using static System.Console;

namespace Exer3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultVar = 0;
            double var1 = 1;
            double var2 = 5;
            double var3 = 2;
            double var4 = 3;
            double var5 = 4;

            // The order in which the operators take precedence
            double stepOne = var1 * var2;
            double stepTwo = var4 / var5;
            double stepThree = var3 % stepTwo;
            double stepFour = stepOne + stepThree;
            double manualResult = resultVar + stepFour;
            WriteLine($"Manual result: {manualResult}");

            resultVar += var1 * var2 + var3 % var4 / var5;
            WriteLine($"Result: {resultVar}");
        }
    }
}
