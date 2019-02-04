using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "end")
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    break;
                }
                string[] splittedInput = input.Split();
                if (splittedInput.Length == 2) // only 1 number
                {
                    string command = splittedInput[0].ToLower();
                    int number = int.Parse(splittedInput[1]);
                    if (command == "add")
                    {
                        stack.Push(number);
                    }
                    else if (command == "remove") // need to remove last n elements..
                    {
                        int firstNumber = int.Parse(splittedInput[1]);

                        if (stack.Count >= firstNumber)
                        {
                            for (int i = 0; i < firstNumber; i++)
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
                else if (splittedInput.Length == 3)
                {
                    string command = splittedInput[0].ToLower();

                    if (command == "add")
                    {
                        int firstNumber = int.Parse(splittedInput[1]);
                        int secondNumber = int.Parse(splittedInput[2]);

                        stack.Push(firstNumber);
                        stack.Push(secondNumber);
                    }
                    else if (command == "remove") // need to remove last n elements..
                    {
                        int firstNumber = int.Parse(splittedInput[1]);

                        if (stack.Count >= firstNumber)
                        {
                            for (int i = 0; i < firstNumber; i++)
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
            }

        }
    }
}

