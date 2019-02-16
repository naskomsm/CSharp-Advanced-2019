namespace StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            SortedSet<Person> setByName = new SortedSet<Person>(new PersonNameComperer());
            SortedSet<Person> setByAge = new SortedSet<Person>(new PersonAgeComperer());

            for (int i = 0; i < linesCount; i++)
            {
                string[] personArgs = Console.ReadLine().Split();

                string name = personArgs[0];
                int age = int.Parse(personArgs[1]);

                Person person = new Person(name, age);
                setByName.Add(person);
                setByAge.Add(person);
            }

            foreach (var person in setByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in setByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
