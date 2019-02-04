using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Func<List<int>, List<int>> addFunc = x => x.Select(a => a+=1).ToList();
            Func<List<int>, List<int>> subtractFunc = x => x.Select(a => a-=1).ToList();
            Func<List<int>, List<int>> multiplyFunc = x => x.Select(a => a*=2).ToList();

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ",x));

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "end")
                {
                    break;
                }


                if (command == "add")
                {
                    numbers = addFunc(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtractFunc(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiplyFunc(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }
        }
    }
}
