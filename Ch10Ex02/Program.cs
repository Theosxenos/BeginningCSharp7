using static System.Console;
namespace Ch10Ex02
{
    public class ClassA
    {
        private int state = -1;
        public int State => state;
        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create main class, show current val of state
            ClassA myObject = new ClassA();
            WriteLine($"myObject.State = {myObject.State}");

            // Create the subclass, call its method and pass the main class
            ClassA.ClassB myOtherObject = new ClassA.ClassB(); // Interessant dat een subclass van een object toegang heeft tot de private members van een ander object
            myOtherObject.SetPrivateState(myObject, 999);

            // Show the current val of state
            WriteLine($"myObject.State = {myObject.State}");
        }
    }
}