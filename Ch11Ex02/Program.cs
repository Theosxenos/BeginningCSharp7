using System.Collections;
using static System.Console;

namespace Ch11Ex02
{
    public class Animals : CollectionBase
    {
        public void Add(Animal animal)
        {
            List.Add(animal);
        }

        public void Remove(Animal animal)
        {
            List.Remove(animal);
        }

        public Animal this[int animalIndex]
        {
            get
            {
                return (Animal)List[animalIndex];
            }
            set
            {
                List[animalIndex] = value;
            }
        }
    }
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
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Mary"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
        }
    }
}
