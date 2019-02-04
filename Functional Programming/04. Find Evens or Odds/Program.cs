using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rangeArguments = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int start = rangeArguments[0];
            int end = rangeArguments[1];

            string typeNumbers = Console.ReadLine();
            Func<int,bool> filter = x => typeNumbers == "odd" ? x % 2 != 0 : x % 2 == 0;
            
            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(" ",numbers.Where(filter)));
        }
    }
}
