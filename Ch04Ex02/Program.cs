﻿using System;
using static System.Console;
using static System.Convert;

namespace Ch04Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison; 
            
            // Ask for numbers
            WriteLine("Enter a number:");
            double var1 = ToDouble(ReadLine());
            
            WriteLine("Enter another number:");
            double var2 = ToDouble(ReadLine());
            
            // Compared the 2 asked numbers
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            
            // Show result
            WriteLine($"The first number is {comparison} the second number.");
        }
    }
}