using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();


            int elementsToPush = operations[0];
            int elementsToPop = operations[1];
            int elementToLook = operations[2];

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                int minNumber = stack.Min();
                Console.WriteLine(minNumber);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
