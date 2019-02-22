namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());


            string[][] matrix = new string[rows][];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                matrix[row] = input;
            }

            string[] commandLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = commandLine[0];
            string header = commandLine[1];

            int headerIndex = -1;

            if (command == "hide")
            {

                // faster way...( only hiding the column but not deleting it )
                //for (int row = 0; row < matrix.Length; row++)
                //{
                //    List<string> lineToPrint = new List<string>();

                //    lineToPrint.AddRange(matrix[row].Take(headerIndex).ToList());
                //    lineToPrint.AddRange(matrix[row].Skip(headerIndex + 1));

                //    Console.WriteLine(string.Join(" | ", lineToPrint));

                //    // if we want to delete
                //    // table[row] = lineToPrint.ToArray();
                //}


                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row].Contains(header))
                    {
                        headerIndex = Array.IndexOf(matrix[row], header);
                    }
                }

                Console.WriteLine(string.Join(" | ", matrix[0].Where(x => x != header)));

                for (int row = 1; row < rows; row++)
                {
                    Console.WriteLine(string.Join(" | ", matrix[row].Where((r, c) => c != headerIndex))); // skip the colIndex while printing
                }
            }
            else if (command == "sort")
            {
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row].Contains(header))
                    {
                        headerIndex = Array.IndexOf(matrix[row], header);
                    }
                }

                Console.WriteLine(string.Join(" | ", matrix[0]));

                foreach (var row in matrix.OrderBy(x => x[headerIndex]))
                {
                    if (!row.Contains(header)) // row[0] containts the header , so we skip it and print everything that does not contain the header....
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                }
            }
            else if (command == "filter")
            {
                var value = commandLine[2];

                for (int i = 0; i < matrix[0].Length; i++)
                {
                    if (matrix[0][i] == header)
                    {
                        headerIndex = i;
                    }
                }

                Console.WriteLine(string.Join(" | ", matrix[0]));

                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row][headerIndex].Contains(value))
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }
                }
            }
        }
    }
}