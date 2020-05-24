using System;
using System.Diagnostics;
using System.Drawing;

namespace Exer8._5
{

    abstract class HotDrink
    {
        private object Milk { get; set; }
        private object Sugar { get; set; }
        public abstract void Drink();
        public abstract void AddMilk();
        public abstract void AddSugar();
    }

    interface ICup
    {
        Color Color { get; set; }
        double Volume { get; set; }

        public void Refill();
        public void Wash();
    }

    /// <summary>
    /// Class for a cup of tea
    /// </summary>
    class CupOfTea : HotDrink, ICup
    {
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LeafType { get; set; }
        public override void AddMilk()
        {
            Console.WriteLine("Adding Milk to Tea");
        }

        public override void AddSugar()
        {
            throw new NotImplementedException();
        }

        public override void Drink()
        {
            Console.WriteLine("Drinking Tea");
        }

        public void Refill()
        {
            Console.WriteLine("Refilling Tea");
        }

        public void Wash()
        {
            Console.WriteLine("Washing Tea");
        }

    }

    /// <summary>
    /// Class for a cup of coffee
    /// </summary>
    class CupOfCoffee : HotDrink, ICup
    {
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string BeanType { get; set; }
        public override void AddMilk()
        {
            Console.WriteLine("Adding Milk to Coffee");
        }

        public override void AddSugar()
        {
            throw new NotImplementedException();
        }

        public override void Drink()
        {
            Console.WriteLine("Drinking Coffee");
        }

        public void Refill()
        {
            Console.WriteLine("Refilling Coffee");
        }

        public void Wash()
        {
            Console.WriteLine("Washing Coffee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Use Cup of Coffee
            Console.WriteLine("Using cup of coffee");
            UseHotdrinks(new CupOfCoffee());

            // Use Cup of Tea
            Console.WriteLine("Using cup of tea");
            UseHotdrinks(new CupOfTea());

        }

        static void UseHotdrinks(HotDrink hotDrink)
        {
            hotDrink.AddMilk();
            hotDrink.Drink();

            // Book Solution
            // Because not all HotDrinks have to be ICups, check
            if (hotDrink is ICup)
                ((ICup)hotDrink).Wash();
        }
    }
}
