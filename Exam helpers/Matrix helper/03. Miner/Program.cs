using System;
using System.Linq;

namespace _03._Miner___Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            string[][] matrix = new string[n][];
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                matrix[row] = new string[n];
                matrix[row] = input;
            } // get the matrix

            int playerRow = -1;
            int playerCol = -1;

            int coalLeft = 0;


            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row][col] == "s")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    if (matrix[row][col] == "c")
                    {
                        coalLeft++;
                    }
                }
            } // find the start postition

            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up":
                        playerRow = playerRow - 1 < 0 ? playerRow : playerRow - 1;
                        break;
                    case "down":
                        playerRow = playerRow + 1 >= n ? playerRow : playerRow + 1;
                        break;
                    case "left":
                        playerCol = playerCol - 1 < 0 ? playerCol : playerCol - 1;
                        break;
                    case "right":
                        playerCol = playerCol + 1 >= n ? playerCol : playerCol + 1;
                        break;
                }

                if (matrix[playerRow][playerCol] == "e")
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    return;
                }
                else if (matrix[playerRow][playerCol] == "c")
                {
                    matrix[playerRow][playerCol] = "*";
                    coalLeft--;
                    if (coalLeft == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{coalLeft} coals left. ({playerRow}, {playerCol})");

        }
    }
}