using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> storage = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!storage.ContainsKey(currentChar))
                {
                    storage.Add(currentChar, 1);
                }
                else
                {
                    storage[currentChar]++;
                }
            }

            foreach (var element in storage.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }
        }
    }
}
