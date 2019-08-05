namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] firstNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> leftSocks = new Stack<int>(firstNumbers);
            Queue<int> rightSocks = new Queue<int>(secondNumbers);

            List<int> pairs = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                if (leftSocks.Peek() > rightSocks.Peek())
                {
                    int pair = leftSocks.Pop() + rightSocks.Dequeue();
                    pairs.Add(pair);
                }
                else if (leftSocks.Peek() < rightSocks.Dequeue())
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    int tempIncrement = leftSocks.Pop() + 1;
                    leftSocks.Push(tempIncrement);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
