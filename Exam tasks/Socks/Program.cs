namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int[] leftSocksArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] rightSocksArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> leftSocks = new Stack<int>(leftSocksArr);
            Queue<int> rightSocks = new Queue<int>(rightSocksArr);

            int biggestPair = 0;
            List<int> pairs = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                if (leftSocks.Peek() > rightSocks.Peek())
                {
                    int pair = leftSocks.Pop() + rightSocks.Dequeue();
                    if (pair > biggestPair)
                    {
                        biggestPair = pair;
                    }
                    pairs.Add(pair);
                }

                else if (rightSocks.Peek() > leftSocks.Peek())
                {
                    leftSocks.Pop();
                }

                else if (rightSocks.Peek() == leftSocks.Peek())
                {
                    rightSocks.Dequeue();
                    int temp = leftSocks.Pop() + 1;
                    leftSocks.Push(temp);
                }

            }

            Console.WriteLine(biggestPair);
            Console.WriteLine(string.Join(" ", pairs));

        }
    }
}
