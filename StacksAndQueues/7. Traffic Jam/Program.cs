using System;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> stack = new Stack<string>();
            int numberOfMaximumPassedCars = int.Parse(Console.ReadLine());
            int counter = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                else if (stack.Count == 4)
                {
                    if (input == "green")
                    {
                        foreach (var item in stack)
                        {
                            Console.WriteLine($"{stack.Pop()} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    stack.Push(input);
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
