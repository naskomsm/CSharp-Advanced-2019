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
            Queue<int> queue = new Queue<int>();


            int elementsToPush = operations[0];
            int elementsToPop = operations[1];
            int elementToLook = operations[2];

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                int minNumber = queue.Min();
                Console.WriteLine(minNumber);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
