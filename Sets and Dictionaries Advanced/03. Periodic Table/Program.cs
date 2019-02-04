using System;
using System.Collections;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elementsHash = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int h = 0; h < elements.Length; h++)
                {
                    string currentElement = elements[h];
                    elementsHash.Add(currentElement);
                }
            }

            foreach (var element in elementsHash)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }
    }
}
