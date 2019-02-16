namespace Stack
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            CustomStack<int> stack = new CustomStack<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] splittedInput = input.Split(" ", 2);

                string command = splittedInput[0];

                if (command == "Push")
                {
                    int[] numbers = splittedInput[1].Split(", ").Select(int.Parse).ToArray();
                    stack.Push(numbers);
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var number in stack)
                {
                    Console.WriteLine(number);
                }
            }


        }
    }
}
