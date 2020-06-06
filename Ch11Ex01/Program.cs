using System.Collections;
using System.Collections.Generic;
using static System.Console;

namespace Ch11Ex01
{
    public abstract class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal() => name = "An animal has no name";
        public Animal(string newName) => name = newName;
        public void Feed() => WriteLine($"{name} has been fed.");
    }
    public class Cow : Animal
    {
        public void Milk() => WriteLine($"{name} has been milked.");
        public Cow(string newName) : base(newName) { }
    }
    public class Chicken : Animal
    {
        public void LayEgg() => WriteLine($"{name} has laid an egg.");
        public Chicken(string newName) : base(newName) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Create an Array type collection of Animal objects and use it:");

            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");
            
            foreach (Animal myAnimal in animalArray)
            {
                WriteLine($"New {myAnimal.ToString()} object added to Array collection, Name = {myAnimal.Name}");
            }
            
            WriteLine($"Array collection contains {animalArray.Length} objects.");
            
            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            
            WriteLine();
            WriteLine("Create an ArrayList type collection of Animal objects and use it:");

            /// The ArrayList collection is a collection of System.Object objects
            //ArrayList animalArrayList = new ArrayList();
            List<Animal> animalArrayList = new List<Animal>();
            Cow myCow2 = new Cow("Donna");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Andrea"));
            
            foreach (Animal myAnimal in animalArrayList)
            {
                WriteLine($"New {myAnimal.ToString()} object added to ArrayList collection, Name = {myAnimal.Name}");
            }
            WriteLine($"ArrayList collection contains {animalArrayList.Count} objects.");

            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            
            WriteLine();
            WriteLine("Additional manipulation of ArrayList:");
            
            animalArrayList.RemoveAt(0);
            
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList[0].Feed();

            animalArrayList.AddRange(animalArray);
            
            ((Chicken)animalArrayList[2]).LayEgg();
            
            WriteLine($"The animal called {myCow1.Name} is at index {animalArrayList.IndexOf(myCow1)}.");
            
            myCow1.Name = "Mary";
            WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name }.");
        }
    }
}
