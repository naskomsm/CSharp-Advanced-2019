using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[]> print = x => Console.WriteLine(string.Join(Environment.NewLine,x.Select(y=> $"Sir {y}")));
            print(input);
        }
    }
}
