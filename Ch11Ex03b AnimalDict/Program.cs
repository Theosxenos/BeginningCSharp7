using System;
using System.Collections;

namespace Ch11Ex03b_AnimalDict
{
    public class Animal
    {
        public string Name { get; set; }
        public Animal(string name) => Name = name;
        public override string ToString() => $"My name is {Name}";
    }
    public class Animals : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal) => Dictionary.Add(newID, newAnimal);
        public void Remove(string animalID) => Dictionary.Remove(animalID);
        public Animal this[string animalID]
        {
            get { return (Animal)Dictionary[animalID]; }
            set { Dictionary[animalID] = value; }
        }
        public new IEnumerator GetEnumerator()
        {
            foreach (object animal in Dictionary.Values)
                yield return (Animal)animal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animals animalCollection = new Animals();

            animalCollection.Add("Cow", new Animal("Cow"));
            animalCollection.Add("Fox", new Animal("Fox"));

            foreach (var animal in animalCollection)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
