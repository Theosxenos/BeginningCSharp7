using System;

namespace Exer11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people.Add(new Person() { Name = "Piet", Age = 12 });
            people.Add(new Person() { Name = "Jan", Age = 22 });
            people.Add(new Person() { Name = "Janine", Age = 22 });

            //Console.WriteLine(people["Piet"]);

            var oldestpeople = people.GetOldest();
            Console.WriteLine("Oldest people in list:");
            foreach(var oldest in oldestpeople)
            {
                Console.WriteLine(oldest);
            }
            Console.WriteLine("The ages in the list:");
            foreach (int age in people.Ages)
            {
                Console.WriteLine(age);
            }
        }
    }
}
