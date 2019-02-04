using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            // getting the array
            for (int r = 0; r < rows; r++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[r] = new int[numbers.Length];
                for (int c = 0; c < numbers.Length; c++)
                {
                    matrix[r][c] = numbers[c];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if(input[0] == "END")
                {
                    break;
                }
                if(input[0] == "Add")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);
                    if(row<rows && col < rows && row >= 0 && col >= 0)
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (input[0] == "Subtract")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);
                    if (row < rows && col < rows && row>=0 && col>=0)
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
