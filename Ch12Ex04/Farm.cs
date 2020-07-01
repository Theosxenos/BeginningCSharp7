using System.Collections;
using System.Collections.Generic;

namespace Ch12Ex04
{
    /// <summary>
    /// Farm class, extends the IEnumerable interface so it can hold Animal objects
    /// </summary>
    /// <typeparam name="T">Animal object</typeparam>
    public class Farm<T> : IEnumerable<T> where T : Animal
    {
        private List<T> animals = new List<T>();
        /// <summary>
        /// Public getter for the Animal list
        /// </summary>
        public List<T> Animals
        {
            get { return animals; }
        }
        public IEnumerator<T> GetEnumerator() => animals.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => animals.GetEnumerator();
        /// <summary>
        /// Loop through all animals and execute the MakeANoise method
        /// </summary>
        public void MakeNoises()
        {
            foreach (T animal in animals)
            {
                animal.MakeANoise();
            }
        }
        /// <summary>
        /// Loop through all animals and execute the Feed method
        /// </summary>
        public void FeedTheAnimals()
        {
            foreach (T animal in animals)
            {
                animal.Feed();
            }
        }
        /// <summary>
        /// Return all animal object of the Cow class
        /// </summary>
        /// <returns></returns>
        public Farm<Cow> GetCows()
        {
            Farm<Cow> cowFarm = new Farm<Cow>();
            foreach (T animal in animals)
            {
                if (animal is Cow)
                {
                    cowFarm.Animals.Add(animal as Cow);
                }
            }
            return cowFarm;
        }
    }
}
