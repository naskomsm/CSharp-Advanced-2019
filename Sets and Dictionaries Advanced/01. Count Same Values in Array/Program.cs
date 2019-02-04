using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> storage = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];
                if (!storage.ContainsKey(currentNumber))
                {
                    storage.Add(currentNumber, 1);
                }
                else
                {
                    storage[currentNumber]++;
                }

            }

            foreach (var kvp in storage)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
