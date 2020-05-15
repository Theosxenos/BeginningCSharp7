using static System.Console;

namespace Ch06Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"{args.Length} command line arguments were specified:");

            foreach (string arg in args)
                WriteLine(arg);
        }
    }
}
