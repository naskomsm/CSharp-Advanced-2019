using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string personName = info[0];
                int personAge = int.Parse(info[1]);

                Person person = new Person(personName, personAge);
                family.AddMember(person);
            }

            //Person oldestPerson = family.GetOldestMember();
            //Console.WriteLine(oldestPerson);


            List<Person> peopleOverThirty = family.GetPeopleOverThirty().OrderBy(x => x.Name).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, peopleOverThirty));
        }
    }
}
