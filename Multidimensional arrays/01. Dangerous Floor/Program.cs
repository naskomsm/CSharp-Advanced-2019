namespace _01._Dangerous_Floor___Matrix
{
    using System;

    public class Program
    {
        static void Main()
        {
            // input
            char[][] matrix = new char[8][];
            for(int row = 0; row < 8; row++)
            {
                matrix[row] = Console.ReadLine().Replace(",", "").ToCharArray();
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] splittedInput = input.Split("-");

                string symbol = splittedInput[0][0].ToString();
                int currentRow = int.Parse(splittedInput[0][1].ToString());
                int currentCol = int.Parse(splittedInput[0][2].ToString());

                int newRow = int.Parse(splittedInput[1][0].ToString());
                int newCol = int.Parse(splittedInput[1][1].ToString());


                if (matrix[currentRow][currentCol].ToString() != symbol)
                {
                    Console.WriteLine("There is no such a piece!");
                    continue;
                }

                if (!CanMove(symbol, currentRow, currentCol, newRow, newCol))
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                if (newRow > 7 || newCol > 7)
                {
                    Console.WriteLine("Move go out of board!");
                    continue;
                }

                matrix[currentRow][currentCol] = 'x';
                matrix[newRow][newCol] = char.Parse(symbol.ToString());

            }
        }

        private static bool CanMove(string piece, int startRow, int startCol, int endRow, int endCol)
        {
            switch (piece)
            {
                case "K":
                    return Math.Max(Math.Abs(endRow - startRow), Math.Abs(endCol - startCol)) == 1;
                case "B":
                    return Math.Abs(endRow - startRow) == Math.Abs(endCol - startCol);
                case "R":
                    return startRow == endRow || startCol == endCol;
                case "Q":
                    return Math.Abs(endRow - startRow) == Math.Abs(endCol - startCol) || (startRow == endRow || startCol == endCol);
                case "P":
                    return startCol == endCol && startRow == endRow + 1;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
}
