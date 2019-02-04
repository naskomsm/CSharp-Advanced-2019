using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                if (findNoIsDivisibleOrNot(numbers, i)) output.Add(i);
            }
            Console.WriteLine(string.Join(" ",output));
        
        }

        static bool findNoIsDivisibleOrNot(List<int> a, int n)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (n % a[i] != 0)
                    return false;
            }
            return true;
        }

    }
}
