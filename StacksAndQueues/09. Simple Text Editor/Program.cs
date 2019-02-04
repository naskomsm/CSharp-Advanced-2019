using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<string> versions = new Stack<string>();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                switch (command)
                {
                    case "1":
                        versions.Push(text.ToString());
                        string someString = input[1];
                        text.Append(someString);
                        break;
                    case "2":
                        versions.Push(text.ToString());
                        int removeElementsCount = int.Parse(input[1]);
                        text.Remove(text.Length - removeElementsCount, removeElementsCount);
                        break;
                    case "3":
                        int numberOfIndex = int.Parse(input[1]) - 1;
                        Console.WriteLine(text[numberOfIndex]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(versions.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}