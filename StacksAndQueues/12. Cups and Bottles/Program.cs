using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cupsQueue = new Queue<int>(cupsCapacity);
            Stack<int> bottlesStack = new Stack<int>(filledBottles);

            int wastedWater = 0;

            while (cupsQueue.Any() && bottlesStack.Any())
            {
                if (bottlesStack.Peek() >= cupsQueue.Peek())
                {
                    int result = bottlesStack.Pop() - cupsQueue.Dequeue();
                    wastedWater += result;
                }
                else if (cupsQueue.Peek() <= 0)
                {
                    cupsQueue.Dequeue();
                }
                else if (cupsQueue.Peek() > bottlesStack.Peek())
                {
                    int mergedBottles = bottlesStack.Pop();
                    while (mergedBottles < cupsQueue.Peek())
                    {
                        mergedBottles += bottlesStack.Pop();
                    }
                    int result = mergedBottles - cupsQueue.Dequeue();
                    wastedWater += result;
                }
            }
            if (!cupsQueue.Any() && bottlesStack.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}");
            }
            else if (cupsQueue.Any() && !bottlesStack.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}