﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());
            Func<int, bool> func = x => x % n != 0;
            Console.WriteLine(string.Join(" ",numbers.Where(func).Reverse()));

        }
    }
}
