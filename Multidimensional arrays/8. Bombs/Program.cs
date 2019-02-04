using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int row = 0; row < n; row++)
            {
                  int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                  matrix[row] = new int[n];
                  matrix[row] = numbers;
            }

            string[] coordinates = Console.ReadLine().Split();
            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] splittedCoordinates = coordinates[i].Split(",");

                int currentRowBomb = int.Parse(splittedCoordinates[0]);
                int currentColBomb = int.Parse(splittedCoordinates[1]);

                if(currentRowBomb < n && currentRowBomb >= 0 && currentColBomb < n && currentColBomb >= 0)
                {
                    if(matrix[currentRowBomb][currentColBomb] > 0)
                    {

                        // i sq golqmoto pisane deeba
                        if (currentRowBomb - 1 >= 0 && currentRowBomb - 1 < n && currentColBomb - 1 >= 0 && currentColBomb-1 < n)
                        {
                            if(matrix[currentRowBomb - 1][currentColBomb - 1] > 0)
                            {
                                matrix[currentRowBomb - 1][currentColBomb - 1] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if (currentRowBomb - 1 >= 0 && currentRowBomb-1 < n && currentColBomb >= 0 && currentColBomb < n)
                        {
                            if(matrix[currentRowBomb - 1][currentColBomb] > 0)
                            {
                                matrix[currentRowBomb - 1][currentColBomb] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if (currentRowBomb - 1 >= 0 && currentRowBomb-1 < n && currentColBomb + 1 >= 0 && currentColBomb+1 < n)
                        {
                            if(matrix[currentRowBomb -1][currentColBomb+1] > 0)
                            {
                                matrix[currentRowBomb - 1][currentColBomb + 1] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if (currentRowBomb >= 0 && currentRowBomb < n && currentColBomb - 1 >= 0 && currentColBomb-1 < n)
                        {
                            if(matrix[currentRowBomb][currentColBomb-1] > 0)
                            {
                                matrix[currentRowBomb][currentColBomb - 1] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if (currentRowBomb >= 0 && currentRowBomb < n && currentColBomb + 1 >= 0 && currentColBomb + 1 < n)
                        {
                            if(matrix[currentRowBomb][currentColBomb+1] > 0)
                            {
                                matrix[currentRowBomb][currentColBomb + 1] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if (currentRowBomb + 1 >= 0 && currentRowBomb + 1 < n && currentColBomb - 1 >= 0 && currentColBomb-1 < n)
                        {
                            if (matrix[currentRowBomb + 1][currentColBomb - 1] > 0)
                            {
                                matrix[currentRowBomb + 1][currentColBomb - 1] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if(currentRowBomb + 1 >= 0 && currentRowBomb + 1 < n && currentColBomb >= 0 && currentColBomb < n)
                        {
                            if (matrix[currentRowBomb + 1][currentColBomb] > 0)
                            {
                                matrix[currentRowBomb + 1][currentColBomb ] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        ////////////////////////////////////////////////////////////////////////////////////////////////
                        if(currentRowBomb + 1 >= 0 && currentRowBomb + 1 < n && currentColBomb + 1 >= 0 && currentColBomb + 1 < n)
                        {
                            if (matrix[currentRowBomb + 1][currentColBomb + 1] > 0)
                            {
                                matrix[currentRowBomb + 1][currentColBomb + 1] -= matrix[currentRowBomb][currentColBomb];
                            }
                        }
                        matrix[currentRowBomb][currentColBomb] = 0;
                    }
                }
            }

            int aliveCells = 0;
            int aliveCellsSum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if(matrix[row][col] > 0)
                    {
                        aliveCells++;
                        aliveCellsSum += matrix[row][col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(" ", r))));
        }
    }
}
