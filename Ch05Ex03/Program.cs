using static System.Console;
using static System.Convert;
namespace Ch05Ex03
{
    enum Orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }
    struct Route
    {
        public Orientation direction;
        public double distance;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // vars
            Route myRoute;
            int myDirection;
            double myDistance;

            // Show the choices
            WriteLine("1) North\n2) South\n3) East\n4) West");

            // Ask for a direction, keep asking until a correct one is chosen
            do
            {
                WriteLine("Select a direction:");
                myDirection = ToInt32(ReadLine());
            }
            while ((myDirection < 1) || (myDirection > 4));
            
            // Ask for the distance
            WriteLine("Input a distance:");
            myDistance = ToDouble(ReadLine());

            // Convert te chosen number to the relevant enum
            myRoute.direction = (Orientation)myDirection;
            myRoute.distance = myDistance;
            
            // Show the result
            WriteLine($"myRoute specifies a direction of {myRoute.direction} and a distance of {myRoute.distance}");
        }
    }
}
