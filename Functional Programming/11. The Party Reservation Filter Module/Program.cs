using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                .Split()
                .ToList();


            List<string> helper = new List<string>();
            foreach (var item in guests)
            {
                helper.Add(item);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "Print")
                {
                    break;
                }

                string[] tokens = input.Split(";");

                string command = tokens[0];
                string filterCommand = tokens[1];
                string criteria = tokens[2];

                
                if (command == "Add filter")
                {
                    if (filterCommand == "Starts with")
                    {
                        helper.RemoveAll(x => x.StartsWith(criteria));

                    }
                    else if (filterCommand == "Ends with")
                    {
                        helper.RemoveAll(x => x.EndsWith(criteria));

                    }
                    else if (filterCommand == "Length")
                    {
                        helper.RemoveAll(x => x.Length == int.Parse(criteria));
                    }
                    else if(filterCommand == "Contains")
                    {
                        helper.RemoveAll(x => x.Contains(criteria));
                    }
                }
                else if(command == "Remove filter")
                {
                    List<string> guestToAdd = new List<string>();
                    if (filterCommand == "Starts with")
                    {
                       guestToAdd = guests.Where(x => x.StartsWith(criteria)).ToList();

                    }
                    else if (filterCommand == "Ends with")
                    {
                        guestToAdd = guests.Where(x => x.EndsWith(criteria)).ToList();
                    }
                    else if (filterCommand == "Length")
                    {
                        guestToAdd = guests.Where(x => x.Length == int.Parse(criteria)).ToList();
                    }
                    else if (filterCommand == "Contains")
                    {
                        guestToAdd = guests.Where(x => x.Contains(criteria)).ToList();
                    }

                    foreach (var item in guestToAdd)
                    {
                        helper.Insert(0, item);
                    }
                }

            }

            Console.WriteLine(string.Join(" ",helper));

        }
    }
}
