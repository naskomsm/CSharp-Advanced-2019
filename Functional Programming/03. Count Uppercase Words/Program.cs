using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> onlyUpperFunc = x => char.IsUpper(x[0]);

            var words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(onlyUpperFunc)
                .ToList();
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
