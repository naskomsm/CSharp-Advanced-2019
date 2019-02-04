using System;
using System.Collections.Generic;

namespace _6._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);

            int counter = 1;
            while (queue.Count>1)
            {
                if(counter % number == 0)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    counter = 1;
                }
                else
                {
                    string removedPerson = queue.Dequeue();
                    queue.Enqueue(removedPerson);
                    counter++;
                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
