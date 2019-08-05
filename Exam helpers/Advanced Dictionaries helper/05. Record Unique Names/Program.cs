using System;
using System.Collections.Generic;

namespace _05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> storage = new HashSet<string>();


            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                storage.Add(name);
            }

            foreach (var name in storage)
            {
                Console.WriteLine(name);
            }
        }
    }
}
