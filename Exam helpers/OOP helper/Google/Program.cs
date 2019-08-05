namespace Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Person> information = new Dictionary<string, Person>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string[] splittedString = input.Split();
                string personName = splittedString[0];
                if (!information.ContainsKey(personName))
                {
                    information[personName] = new Person(personName);
                }

                switch (splittedString[1])
                {
                    case "company":
                        string companyName = splittedString[2];
                        string department = splittedString[3];
                        decimal salary = decimal.Parse(splittedString[4]);
                        Company company = new Company(companyName, department, salary);
                        information[personName].Company = company;
                        break;
                    case "pokemon":
                        string pokemonName = splittedString[2];
                        string type = splittedString[3];
                        Pokemon pokemon = new Pokemon(pokemonName, type);
                        information[personName].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        string parentName = splittedString[2];
                        string parentBirthday = splittedString[3];
                        Parent parent = new Parent(parentName, parentBirthday);
                        information[personName].Parents.Add(parent);
                        break;
                    case "children":
                        string childName = splittedString[2];
                        string childBirthday = splittedString[3];
                        Child child = new Child(childName, childBirthday);
                        information[personName].Children.Add(child);
                        break;
                    case "car":
                        string model = splittedString[2];
                        int speed = int.Parse(splittedString[3]);
                        Car car = new Car(model, speed);
                        information[personName].Car = car;
                        break;
                }

            }
            
            string searchedName = Console.ReadLine();
            Person person = information.Values.FirstOrDefault(p => p.Name == searchedName);
            Console.WriteLine(person);
        }
    }
}
