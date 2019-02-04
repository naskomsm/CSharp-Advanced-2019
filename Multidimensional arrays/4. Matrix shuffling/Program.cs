using System;
using System.Linq;

namespace _4._Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentInput[col];
                }
            }


            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "END")
                {
                    break;
                }
                switch (command[0])
                {
                    case "swap":
                        if (command.Length == 5)
                        {
                            int row1 = int.Parse(command[1]);
                            int col1 = int.Parse(command[2]);

                            int row2 = int.Parse(command[3]);
                            int col2 = int.Parse(command[4]);

                            if (row1 < rows && col1 < cols && row2 < rows && col2 < cols)
                            {
                                string temp = matrix[row1, col1];
                                matrix[row1, col1] = matrix[row2, col2];
                                matrix[row2, col2] = temp;

                                for (int row = 0; row < rows; row++)
                                {
                                    for (int col = 0; col < cols; col++)
                                    {
                                        Console.Write(matrix[row, col] + " ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
