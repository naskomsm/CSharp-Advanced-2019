using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, bool> func = x => x.Length <= n;
            List<string> input = Console.ReadLine()
                .Split()
                .Where(func)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
