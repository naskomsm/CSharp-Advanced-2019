using System;
using System.Linq;

namespace _1._Diagonal_Difference
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
                int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = numbers[c];
                }
            }

            double firstDiagonal = 0;
            // firstDiagonal
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    firstDiagonal += matrix[row, col];
                    row++;
                }
            }

            double secondDiagonal = 0;
            // secondDiagonal
            for (int row = n-1; row > 0; row--)
            {
                for (int col = 0; col < n; col++)
                {
                    secondDiagonal += matrix[row, col];
                    row--;
                }
            }

            double finalResult = firstDiagonal - secondDiagonal;
            Console.WriteLine(Math.Abs(finalResult));
        }
    }
}
