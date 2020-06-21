using System;
using System.Collections;
using static System.Console;

namespace Ch11Ex05
{
    public class PersonBase
    {
        public string Name;
        public int Age;
        public PersonBase(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Person : PersonBase, IComparable
    {
        public Person(string name, int age) : base(name, age)
        {
        }

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person otherPerson = obj as Person;
                return this.Age - otherPerson.Age;
            }
            else
            {
                throw new ArgumentException("Object to compare to is not a Person object.");
            }
        }
    }
    public class PersonComparerName : IComparer
    {
        public static IComparer Default = new PersonComparerName();
        public int Compare(object x, object y)
        {
            if (x is Person && y is Person)
            {
                return Comparer.Default.Compare(((Person)x).Name, ((Person)y).Name);
            }
            else
            {
                throw new ArgumentException("One or both objects to compare are not Person objects.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add(new PersonBase("A", 66));
            lista.Add(new PersonBase("C", 15));
            lista.Add(new PersonBase("B", 35));
            lista.Sort();
            for (int i = 0; i < lista.Count; i++)
            {
                WriteLine($"{(lista[i] as PersonBase).Name } ({(lista[i] as PersonBase).Age })");
            }

            ArrayList list = new ArrayList();
            list.Add(new Person("Rual", 30));
            list.Add(new Person("Donna", 25));
            list.Add(new Person("Mary", 27));
            list.Add(new Person("Ben", 44));
            WriteLine("Unsorted people:");
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
            WriteLine();
            WriteLine("People sorted with default comparer (by age):");
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }

            WriteLine();
            WriteLine("People sorted with nondefault comparer (by name):");
            list.Sort(PersonComparerName.Default);
            for (int i = 0; i < list.Count; i++)
            {
                WriteLine($"{(list[i] as Person).Name } ({(list[i] as Person).Age })");
            }
        }
    }
}

