using static System.Console;

namespace Ch12Ex02
{
    public class Chicken : Animal
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg.");
        public Chicken(string newName) : base(newName) { }
    }
}
