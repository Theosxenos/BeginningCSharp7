using System;
using static System.Console;
using static System.Convert;

namespace Ch04Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            double balance, interestRate, targetBalance;
            int totalYears = 0;

            // Ask for balance
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());

            // Ask for interest rate
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(ReadLine()) / 100.0;

            // Ask target balance
            WriteLine("What balance would you like to have?");
            targetBalance = ToDouble(ReadLine());
                        
            // Loop until the target balance is met or exceeded
            // Addup the total years needed to meet the balance
            do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);

            // Output the result
            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} you'll have a balance of {balance}.");
        }
    }
}
