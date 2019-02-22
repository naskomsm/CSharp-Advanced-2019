namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<int, List<string>>> departments = new Dictionary<string, Dictionary<int, List<string>>>(); // department -> room and beds(list of patients)
            Dictionary<string, List<string>> doctorAndPatients = new Dictionary<string, List<string>>();
            int index = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Output")
                {
                    break;
                }

                string[] splittedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string department = splittedInput[0];
                string doctor = splittedInput[1] + " " + splittedInput[2];
                string patient = splittedInput[3];

                if (!departments.ContainsKey(department))
                {
                    departments.Add(department, new Dictionary<int, List<string>>());
                    departments[department].Add(index, new List<string>());
                }

                bool isPatientInRoom = false;
                for (int room = 0; room < 20; room++)
                {
                    if (!departments[department].ContainsKey(room))
                    {
                        departments[department].Add(room, new List<string>());
                    }

                    for (int bed = 0; bed < 3; bed++)
                    {
                        if (departments[department][room].Count < 3)
                        {
                            departments[department][room].Add(patient);
                            isPatientInRoom = true;
                            break;
                        }
                    }

                    if (isPatientInRoom)
                    {
                        break;
                    }
                }

                if (!doctorAndPatients.ContainsKey(doctor))
                {
                    doctorAndPatients[doctor] = new List<string>();
                }
                doctorAndPatients[doctor].Add(patient);
            }

            while (true)
            {
                string input = Console.ReadLine().Trim();

                if (input == "End")
                {
                    break;
                }


                if (departments.ContainsKey(input))
                {
                    foreach (var room in departments[input])
                    {
                        foreach (var patient in room.Value)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                }
                else if (doctorAndPatients.ContainsKey(input))
                {
                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string doctor = tokens[0] + " " + tokens[1];

                    foreach (var patient in doctorAndPatients[doctor].OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }
                else
                {
                    string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string department = tokens[0];
                    int room = int.Parse(tokens[1]) - 1;

                    foreach (var bed in departments[department][room].OrderBy(x => x))
                    {
                        Console.WriteLine(bed);
                    }

                }
            }
        }
    }
}
