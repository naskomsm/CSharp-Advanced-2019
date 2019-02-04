using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> storage = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Person person = new Person { Name = info[0], Age = int.Parse(info[1]) };
                if (!storage.Contains(person))
                {
                    storage.Add(person);
                }
            }

            string condition = Console.ReadLine();
            int ageRestriction = int.Parse(Console.ReadLine());

            Func<int,bool> ageChecker (string cond, int age)
            {
                switch (cond)
                {
                    case "younger": return x => x < age;
                    case "older": return x => x >= age;   
                    default:
                    return null;
                }
            }

            string orderCommand = Console.ReadLine();
            switch (orderCommand)
            {
                case "name age" : storage.OrderBy(x => x.Name).ThenBy(x => x.Age);
                    break;
                case "name" : storage.OrderBy(x => x.Name);
                    break;
                case "age" : storage.OrderBy(x => x.Age);
                    break;
                default:
                    break;
            }


        }
    }
}
