using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            int[][] matrix = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = new int[cols];
                matrix[row] = numbers;
            }

            int biggestSum = 0;

            int lowestRow = 0;
            int lowestCol = 0;

            int biggestRow = 0;
            int biggestCol = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if(row < rows && col < cols && row+1<rows && col + 1 < cols && row + 2 < rows && col + 2 < cols)
                    {
                        int currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2]
                            + matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2]
                            + matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                        if (currentSum > biggestSum)
                        {
                            biggestSum = currentSum;

                            lowestRow = row;
                            lowestCol = col;

                            biggestRow = row + 2;
                            biggestCol = col + 2;
                        }
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = lowestRow; row <= biggestRow; row++)
            {
                for (int col = lowestCol; col <= biggestCol; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
