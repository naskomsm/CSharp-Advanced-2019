using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // input array
            int[][] matrix = new int[n][];
            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = new int[n];
                matrix[row] = numbers;
            }

            // cordinates
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                string[] currentCordinates = input[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                int currentRow = int.Parse(currentCordinates[0]);
                int currentCol = int.Parse(currentCordinates[1]);

                int currentBomb = matrix[currentRow][currentCol];

                if (currentRow >= 0 && currentRow < n && currentCol >= 0 && currentCol < n)
                {
                    if (matrix[currentRow][currentCol] > 0)
                    {
                        if (currentRow - 1 >= 0 && currentRow - 1 < n && currentCol - 1 >= 0 && currentCol - 1 < n && matrix[currentRow - 1][currentCol - 1] > 0)
                        {
                            matrix[currentRow - 1][currentCol - 1] -= currentBomb;
                        }
                        if (currentRow - 1 >= 0 && currentRow - 1 < n && currentCol >= 0 && currentCol < n && matrix[currentRow - 1][currentCol] > 0)
                        {
                            matrix[currentRow - 1][currentCol] -= currentBomb;
                        }
                        if (currentRow - 1 >= 0 && currentRow - 1 < n && currentCol + 1 >= 0 && currentCol + 1 < n && matrix[currentRow - 1][currentCol + 1] > 0)
                        {
                            matrix[currentRow - 1][currentCol + 1] -= currentBomb;
                        }
                        if (currentRow >= 0 && currentRow < n && currentCol - 1 >= 0 && currentCol - 1 < n && matrix[currentRow][currentCol - 1] > 0)
                        {
                            matrix[currentRow][currentCol - 1] -= currentBomb;
                        }
                        if (currentRow >= 0 && currentRow < n && currentCol + 1 >= 0 && currentCol + 1 < n && matrix[currentRow][currentCol + 1] > 0)
                        {
                            matrix[currentRow][currentCol + 1] -= currentBomb;
                        }
                        if (currentRow + 1 >= 0 && currentRow + 1 < n && currentCol + 1 >= 0 && currentCol + 1 < n && matrix[currentRow + 1][currentCol + 1] > 0)
                        {
                            matrix[currentRow + 1][currentCol + 1] -= currentBomb;
                        }
                        if (currentRow + 1 >= 0 && currentRow + 1 < n && currentCol >= 0 && currentCol < n && matrix[currentRow + 1][currentCol] > 0)
                        {
                            matrix[currentRow + 1][currentCol] -= currentBomb;
                        }
                        if (currentRow + 1 >= 0 && currentRow + 1 < n && currentCol - 1 >= 0 && currentCol - 1 < n && matrix[currentRow + 1][currentCol - 1] > 0)
                        {
                            matrix[currentRow + 1][currentCol - 1] -= currentBomb;
                        }

                        matrix[currentRow][currentCol] = 0;
                    }
                }
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        sum += matrix[row][col];
                        aliveCells++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }

        }
    }
}
