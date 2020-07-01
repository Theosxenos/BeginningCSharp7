using System.Collections.Generic;

namespace Ch12Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalCollection = new List<Animal>();
            animalCollection.Add(new Cow("Raul"));
            animalCollection.Add(new Chicken("Donna"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
        }
    }
}
