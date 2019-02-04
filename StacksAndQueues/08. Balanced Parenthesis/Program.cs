using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> storage = new Stack<string>();

            bool isBalanced = true;
            for (int i = 0; i < input.Length; i++)
            {
                string currentChar = input[i].ToString();

                if (currentChar == "(" || currentChar == "[" || currentChar == "{")
                {
                    storage.Push(currentChar);
                }
                else if (currentChar == ")" || currentChar == "]" || currentChar == "}")
                {
                    switch (currentChar)
                    {
                        case ")":
                            if (!storage.Any())
                            {
                                isBalanced = false;
                            }
                            else if (storage.Pop() != "(")
                            {
                                isBalanced = false;
                            }
                            break;
                        case "]":
                            if (!storage.Any())
                            {
                                isBalanced = false;
                            }
                            else if (storage.Pop() != "[")
                            {
                                isBalanced = false;
                            }
                            break;
                        case "}":
                            if (!storage.Any())
                            {
                                isBalanced = false;
                            }
                            else if (storage.Pop() != "{")
                            {
                                isBalanced = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            if (isBalanced) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
