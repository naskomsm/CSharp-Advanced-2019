using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> storage = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!storage.ContainsKey(continent))
                {
                    storage.Add(continent, new Dictionary<string, List<string>>());
                    if (!storage[continent].ContainsKey(country))
                    {
                        storage[continent].Add(country, new List<string>());
                        if (!storage[continent][country].Contains(city))
                        {
                            storage[continent][country].Add(city);
                        }
                    }
                    else
                    {
                        if (!storage[continent][country].Contains(city))
                        {
                            storage[continent][country].Add(city);
                        }
                    }
                }
                else
                {
                    if (!storage[continent].ContainsKey(country))
                    {
                        storage[continent].Add(country, new List<string>());
                        if (!storage[continent][country].Contains(city))
                        {
                            storage[continent][country].Add(city);
                        }
                    }
                    else
                    {
                        if (!storage[continent][country].Contains(city))
                        {
                            storage[continent][country].Add(city);
                        }
                    }
                }
            }

            foreach (var kvp in storage)
            {
                var continentName = kvp.Key;
                var countryNameAndCityName = kvp.Value;

                Console.WriteLine($"{continentName}: ");

                foreach (var name in countryNameAndCityName)
                {
                    Console.WriteLine($"  {name.Key} -> {string.Join(", ", name.Value)}");
                }

            }
        }
    }
}
