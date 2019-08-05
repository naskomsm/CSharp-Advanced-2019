using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> storage = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("->",StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string items = input[1];

                string[] splittedItems = items.Split(",");

                if (!storage.ContainsKey(color))
                {
                    storage.Add(color, new Dictionary<string, int>());
                    for (int h = 0; h < splittedItems.Length; h++)
                    {
                        string currentItem = splittedItems[h].Trim();
                        if (!storage[color].ContainsKey(currentItem))
                        {
                            storage[color].Add(currentItem, 1);
                        }
                        else
                        {
                            storage[color][currentItem]++;
                        }
                    }
                }
                else
                {
                    for (int h = 0; h < splittedItems.Length; h++)
                    {
                        string currentItem = splittedItems[h].Trim(); ;
                        if (!storage[color].ContainsKey(currentItem))
                        {
                            storage[color].Add(currentItem, 1);
                        }
                        else
                        {
                            storage[color][currentItem]++;
                        }
                    }
                }
            }

            string[] command = Console.ReadLine().Split();
            string colorToFind = command[0];
            string clotheToFind = command[1];

            foreach (var kvp in storage)
            {
                var color = kvp.Key.Trim();
                var clothes = kvp.Value;
                Console.WriteLine($"{color} clothes: ");

                foreach (var clothe in clothes)
                {
                    string clotheName = clothe.Key.Trim();
                    if(clotheName == clotheToFind && colorToFind == color)
                    {
                        Console.WriteLine($"* {clotheName} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clotheName} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
