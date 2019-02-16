namespace ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }

                string[] splittedInput = input.Split();

                string name = splittedInput[0];
                int age = int.Parse(splittedInput[1]);
                string town = splittedInput[2];

                Person newPerson = new Person(name,age,town);
                people.Add(newPerson);
            }

            int personNumber = int.Parse(Console.ReadLine());
            Person currentPerson = people[personNumber - 1];

            int equalPeople = 0;
            int notEqualPeople = 0;

            for (int i = 0; i < people.Count; i++)
            {
                if (currentPerson.CompareTo(people[i]) == 0)
                {
                    equalPeople++;
                }
                else
                {
                    notEqualPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
