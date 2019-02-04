using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            // reading
            for (int r = 0; r < n; r++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }

            var squareSum = 0;
            // printing
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    squareSum += matrix[row, col];
                    row++;
                }
            }
            Console.WriteLine(squareSum);
        }
    }
}
