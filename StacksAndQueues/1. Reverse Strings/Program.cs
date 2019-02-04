using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingPlace
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openingBracketIndex = stack.Pop();
                    string output = input.Substring(openingBracketIndex, i - openingBracketIndex + 1);
                    Console.WriteLine(output);
                }
            }
        }
    }
}

