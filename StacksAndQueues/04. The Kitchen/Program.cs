using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._The_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] knives = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] forks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(knives);
            Queue<int> queue = new Queue<int>(forks);
            
            List<int> sets = new List<int>();

            while (stack.Any() && queue.Any())
            {
                // knife bigger than fork
                if(stack.Peek() > queue.Peek() && stack.Any() && queue.Any())
                {
                    int currentSet = stack.Peek() + queue.Peek();
                    sets.Add(currentSet);
                    stack.Pop();
                    queue.Dequeue();
                }

                // fork bigger than knife
                if(stack.Any() && queue.Any())
                {
                    if (queue.Peek() > stack.Peek())
                    {
                        stack.Pop();
                        if (stack.Any() && queue.Any())
                        {
                            while (queue.Peek() > stack.Peek())
                            {
                                stack.Pop();
                            }
                        }
                    }
                }

                // equal
                if(stack.Any() && queue.Any())
                {
                    if (queue.Peek() == stack.Peek())
                    {
                        queue.Dequeue();
                        int number = stack.Pop();
                        stack.Push(number + 1);
                    }
                }
            }

            int biggestSet = 0;
            foreach (var item in sets)
            {
                if(item > biggestSet)
                {
                    biggestSet = item;
                }
            }

            Console.WriteLine($"The biggest set is: {biggestSet}");
            Console.WriteLine(string.Join(" ",sets));

        }
    }
}
