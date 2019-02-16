namespace EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            HashSet<Person> hashPeople = new HashSet<Person>();
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personArgs = Console.ReadLine().Split();
                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                hashPeople.Add(person);
                sortedPeople.Add(person);
            }
            Console.WriteLine(hashPeople.Count);
            Console.WriteLine(sortedPeople.Count);
        }
    }
}
