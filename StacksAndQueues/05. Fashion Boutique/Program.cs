using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int racks = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int sum = 0;
            int rackCount = 0;
            while (stack.Any())
            {
                while (stack.Peek() + sum <= racks)
                {
                    sum += stack.Pop();
                    if (stack.Any() == false)
                    {
                        break;
                    }
                }
                rackCount++;
                sum = 0;
            }
            Console.WriteLine(rackCount);
        }
    }
}
