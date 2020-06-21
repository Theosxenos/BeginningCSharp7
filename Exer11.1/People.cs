using System;
using System.Collections;
using System.Collections.Generic;

namespace Exer11._1
{
    public class People : DictionaryBase, ICloneable
    {
        /// <summary>
        /// Deep clones the People object
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            People clonedPeople = new People();
            Person currentPerson, newPerson;
            foreach (DictionaryEntry p in Dictionary)
            {
                currentPerson = p.Value as Person;
                newPerson = new Person();
                newPerson.Name = currentPerson.Name;
                newPerson.Age = currentPerson.Age;
                clonedPeople.Add(newPerson);
            }
            return clonedPeople;
        }

        /// <summary>
        /// Iterate the ages in the current Dictionary
        /// </summary>
        public IEnumerable Ages
        {
            get
            {
                foreach (object person in Dictionary.Values)
                    yield return (person as Person).Age;
            }
        }

        /// <summary>
        /// Add a person
        /// </summary>
        /// <param name="person"></param>
        public void Add(Person person) => Dictionary.Add(person.Name, person);

        /// <summary>
        /// Remove a person
        /// </summary>
        /// <param name="personName"></param>
        public void Remove(string personName) => Dictionary.Remove(personName);
        
        /// <summary>
        /// Get a person through his name-index
        /// </summary>
        /// <param name="personName"></param>
        /// <returns></returns>
        public Person this[string personName]
        {
            get { return (Person)Dictionary[personName]; }
            set { Dictionary[personName] = value; }
        }

        /// <summary>
        /// Iterate all the Person object in the dictionary
        /// </summary>
        /// <returns></returns>
        public new IEnumerator GetEnumerator()
        {
            foreach (object person in Dictionary.Values)
                yield return (Person)person;
        }

        /// <summary>
        /// Returns an array of Person objects with the greatest Age property(one or more objects, as multiple items can have the same value for this property
        /// </summary>
        /// <returns></returns>
        public Person[] GetOldest()
        {
            Person oldestpersondummy = new Person { Age = 0, Name = "Dummy" };
            List<Person> oldestpeople = new List<Person>();
            
            foreach (Person person in this)
            {
                if (person == oldestpersondummy)
                {
                    oldestpeople.Add(person);
                    oldestpersondummy = person;
                }
                else if (person > oldestpersondummy)
                {
                    oldestpeople.Clear();
                    oldestpeople.Add(person);
                    oldestpersondummy = person;
                }
            }

            return oldestpeople.ToArray();
        }
    }
}