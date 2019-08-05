namespace _02._Sneaking
{
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int samRow = -1;
            int samCol = -1;

            int nikoladzeRow = -1;
            int nikoladzeCol = -1;

            // get the matrix and find the niko and sam start position ( works fine )
            char[][] matrix = new char[n][];
            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Replace(" ", "").ToCharArray();
                if (matrix[row].Contains('S'))
                {
                    samRow = row;
                    samCol = Array.IndexOf(matrix[row], 'S');
                    matrix[samRow][samCol] = '.';
                }
                else if (matrix[row].Contains('N'))
                {
                    nikoladzeRow = row;
                    nikoladzeCol = Array.IndexOf(matrix[row], 'N');
                }
            }
            

            string commands = Console.ReadLine();
            foreach (var command in commands)
            {
                for (int row = 0; row < n; row++)
                {
                    if (matrix[row].Contains('b'))
                    {
                        int enemyRow = row;
                        int enemyCol = Array.IndexOf(matrix[row], 'b');

                        if (enemyCol >= matrix[row].Length - 1)
                        {
                            matrix[enemyRow][enemyCol] = 'd';
                            continue;
                        }
                        matrix[enemyRow][enemyCol] = '.';
                        matrix[enemyRow][enemyCol + 1] = 'b';
                        enemyCol += 1;
                    }

                    if (matrix[row].Contains('d'))
                    {
                        int enemyRow = row;
                        int enemyCol = Array.IndexOf(matrix[row], 'd');

                        if (enemyCol <= 0)
                        {
                            matrix[enemyRow][enemyCol] = 'b';
                            continue;
                        }
                        matrix[enemyRow][enemyCol] = '.';
                        matrix[enemyRow][enemyCol - 1] = 'd';
                        enemyCol -= 1;
                    }
                } // enemy movement ( works fine )

                // enemy check ( works fine )
                if (matrix[samRow].Contains('b'))
                {
                    int indexOfEnemy = Array.IndexOf(matrix[samRow], 'b');
                    if (indexOfEnemy < samCol) // sam is dead
                    {
                        matrix[samRow][samCol] = 'X';
                        Console.WriteLine($"Sam died at {samRow}, {samCol}");
                        foreach (var row in matrix)
                        {
                            Console.WriteLine(string.Join("", row));
                        }
                        break;
                    }
                }

                else if (matrix[samRow].Contains('d'))
                {
                    int indexOfEnemy = Array.IndexOf(matrix[samRow], 'd');
                    if (indexOfEnemy > samCol) // sam is dead
                    {
                        matrix[samRow][samCol] = 'X';
                        Console.WriteLine($"Sam died at {samRow}, {samCol}");
                        foreach (var row in matrix)
                        {
                            Console.WriteLine(string.Join("", row));
                        }
                        break;
                    }
                }

                switch (command)
                { 
                    case 'U':
                        samRow = samRow - 1 < 0 ? samRow : samRow - 1;
                        if (matrix[samRow][samCol] == 'b' || matrix[samRow][samCol] == 'd')
                        {
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'D':
                        samRow = samRow + 1 >= n ? samRow : samRow + 1;
                        if (matrix[samRow][samCol] == 'b' || matrix[samRow][samCol] == 'd')
                        {
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'L':
                        samCol = samCol - 1 < 0 ? samCol : samCol - 1;
                        if (matrix[samRow][samCol] == 'b' || matrix[samRow][samCol] == 'd')
                        {
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                    case 'R':
                        samCol = samCol + 1 >= n ? samCol : samCol + 1;
                        if (matrix[samRow][samCol] == 'b' || matrix[samRow][samCol] == 'd')
                        {
                            matrix[samRow][samCol] = '.';
                        }
                        break;
                } // Sam movement ( works fine )

                if (matrix[samRow].Contains('N'))
                {
                    Console.WriteLine($"Nikoladze killed!");
                    matrix[samRow][samCol] = 'S';
                    matrix[nikoladzeRow][nikoladzeCol] = 'X';
                    foreach (var row in matrix)
                    {
                        Console.WriteLine(string.Join("", row));
                    }
                    break;
                } // niko check ( works fine)
                
            }
        }
    }
}
