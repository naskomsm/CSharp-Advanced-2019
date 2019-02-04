namespace FamilyTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            if (char.IsLetter(input[0]))
            {
                string[] splittedInput = input.Split();
                string name = splittedInput[0] + " " + splittedInput[1];

                Person person = new Person(name, string.Empty);

                while (true)
                {
                    string command = Console.ReadLine();
                    if(command == "End")
                    {
                        break;
                    }

                    if (char.IsDigit(command[0])) // 11/11/1951 - 23/5/1980
                    {
                        // left date is PARENT to the right date
                        string[] splittedCommand = command.Split(" - ");

                        string parentBirthdate = splittedCommand[0];
                        string personBirthdate = splittedCommand[1];

                        person.Birthday = personBirthdate;
                        person.Parents.Add(new Parent(string.Empty, parentBirthdate));

                    }
                    else if(char.IsLetter(command[0]) && command.Contains("-")) // Penka Pesheva - 23/5/1980 or Gancho Peshev
                    {
                        string[] splittedCommand = command.Split(" - ");

                        string first = splittedCommand[0];
                        string second = splittedCommand[1];

                        if (char.IsDigit(second[0])) // Penka Pesheva - 23/5/1980
                        {
                            // left is PARENT to the right date

                            string parentName = splittedCommand[0];
                            string personBirthday = splittedCommand[1];

                            person.Birthday = personBirthday;
                            person.Parents.Add(new Parent(parentName, string.Empty));
                        }
                        else // Penka Pesheva - Gancho Peshev
                        {
                            // left is PARENT to the right
                            string parentName = splittedCommand[0];
                            string childName = splittedCommand[1];

                            person.Children.Add(new Child(childName, string.Empty));
                        }
                    }
                    else if(char.IsLetter(command[0]) && !command.Contains("-")) // Gancho Peshev 1/1/2005
                    {
                        // left is parentName; Right is parentBirthday
                        string[] splittedCommand = command.Split();

                        string parentName = splittedCommand[0] + " " + splittedCommand[1];
                        string parentBirthday = splittedCommand[2];

                        // to do ;c

                    }

                }
            }
            else if (char.IsDigit(input[0]))
            {
                string[] splittedInput = input.Split();
                string birthdate = splittedInput[2];

                Person person = new Person(string.Empty, birthdate);

                while (true)
                {
                    string command = Console.ReadLine();
                    if (command == "End")
                    {
                        break;
                    }

                    if (char.IsDigit(command[0])) // 11/11/1951 - 23/5/1980
                    {
                        // left date is PARENT to the right date
                        string[] splittedCommand = command.Split(" - ");

                        string parentBirthdate = splittedCommand[0];
                        string personBirthdate = splittedCommand[1];

                        person.Birthday = personBirthdate;
                        person.Parents.Add(new Parent(string.Empty, parentBirthdate));

                    }
                    else if (char.IsLetter(command[0]) && command.Contains("-")) // Penka Pesheva - 23/5/1980 or Gancho Peshev
                    {
                        string[] splittedCommand = command.Split(" - ");

                        string first = splittedCommand[0];
                        string second = splittedCommand[1];

                        if (char.IsDigit(second[0])) // Penka Pesheva - 23/5/1980
                        {
                            // left is PARENT to the right date

                            string parentName = splittedCommand[0];
                            string personBirthday = splittedCommand[1];

                            person.Birthday = personBirthday;
                            person.Parents.Add(new Parent(parentName, string.Empty));
                        }
                        else // Penka Pesheva - Gancho Peshev
                        {
                            // left is PARENT to the right
                            string parentName = splittedCommand[0];
                            string childName = splittedCommand[1];

                            person.Children.Add(new Child(childName, string.Empty));
                        }
                    }
                    else if (char.IsLetter(command[0]) && !command.Contains("-")) // Gancho Peshev 1/1/2005
                    {
                        // left is parentName; Right is parentBirthday
                        string[] splittedCommand = command.Split();

                        string parentName = splittedCommand[0] + " " + splittedCommand[1];
                        string parentBirthday = splittedCommand[2];

                        if (person.Parents.ToString().Contains($"{parentName} {string.Empty}"))
                        {
                            foreach (var parent in person.Parents)
                            {
                                if (parent.Name == parentName)
                                {
                                    parent.Birthday = parentBirthday; // will crash becouse collection was modified...
                                }
                            }
                        }

                        else if (person.Parents.ToString().Contains($"{string.Empty} {parentBirthday}"))
                        {
                            foreach (var parent in person.Parents)
                            {
                                if (parent.Birthday == parentBirthday)
                                {
                                    parent.Name = parentName;
                                }
                            }
                        }

                    }

                }
            }
        }
    }
}
