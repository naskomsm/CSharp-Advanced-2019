using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parserFunc = int.Parse;
            Func<int, bool> evenFunc = n => n % 2 == 0;
            Func<int, int> orderFunc = n => n;

            var numbers = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parserFunc)
                .Where(evenFunc)
                .OrderBy(orderFunc)
                .ToList();
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
