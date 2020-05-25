using Ch09ClassLib;
using static System.Console;

namespace Ch09Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyExternalClass myObj = new MyExternalClass();
            WriteLine(myObj.ToString());
        }
    }
}
