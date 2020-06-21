using System;
using System.Collections.Generic;
using System.Text;

namespace Exer11._1
{
    public class Person : ICloneable
    {
        private string name;
        private int age;
        /// <summary>
        /// Name of a person
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Age of a person
        /// </summary>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Show the person's name and age
        public override string ToString() => $"Person: {name}, their age: {age}";

        public object Clone()
        {
            return new Person() { Name = this.Name, Age = this.Age };
        }

        // Overrides the compare operators so the person objects can be compared directly
        public static bool operator >(Person person1, Person person2) => person1.Age > person2.Age;
        public static bool operator <(Person person1, Person person2) => person1.Age < person2.Age;
        public static bool operator >=(Person person1, Person person2) => person1.Age >= person2.Age;
        public static bool operator <=(Person person1, Person person2) => person1.Age <= person2.Age;
        public static bool operator ==(Person person1, Person person2) => person1.Age == person2.Age;
        public static bool operator !=(Person person1, Person person2) => person1.Age != person2.Age;

    }
}
