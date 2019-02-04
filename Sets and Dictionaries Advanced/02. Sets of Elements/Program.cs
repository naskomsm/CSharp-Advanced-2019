using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundaries = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> firstHash = new HashSet<int>();
            HashSet<int> secondHash = new HashSet<int>();

            for (int i = 0; i < boundaries[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstHash.Add(number);
            }
            for (int i = 0; i < boundaries[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondHash.Add(number);
            }

            foreach (var element in firstHash)
            {
                if (secondHash.Contains(element))
                {
                    Console.Write($"{element} ");
                }
            }
            Console.WriteLine();
        }
    }
}
