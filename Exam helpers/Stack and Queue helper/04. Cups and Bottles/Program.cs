using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var secondInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int wastedWater = 0;

            Queue<int> cups = new Queue<int>(firstInput);
            Stack<int> bottles = new Stack<int>(secondInput);

            while (cups.Any() && bottles.Any())
            {
                if(bottles.Peek() >= cups.Peek())
                {
                    wastedWater += bottles.Pop() - cups.Dequeue();
                }
                else if(bottles.Peek() < cups.Peek())
                {
                    int newSum = bottles.Pop();
                    while (newSum < cups.Peek())
                    {
                        newSum += bottles.Pop();
                    }
                    int sumWastedWater = newSum - cups.Dequeue();
                    wastedWater += sumWastedWater;
                }
            }
            if(!cups.Any() && bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");

            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }

        }
    }
}
