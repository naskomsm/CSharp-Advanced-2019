using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> storage = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                double mark = double.Parse(input[1]);

                if (!storage.ContainsKey(name))
                {
                    storage.Add(name, new List<double>());
                    storage[name].Add(mark);
                }
                else
                {
                    storage[name].Add(mark);
                }
            }
            foreach (var kvp in storage)
            {
                string student = kvp.Key;
                List<double> grades = kvp.Value;
                var average = grades.Average();
                Console.Write($"{student} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}
