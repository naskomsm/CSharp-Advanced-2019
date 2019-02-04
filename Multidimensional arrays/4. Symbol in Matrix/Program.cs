using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        // 80 - 100 judge wtf.
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new string[n, n];

            // reading the matrix
            for (int r = 0; r < n; r++)
            {
                string symbols = Console.ReadLine();
                string[] symbolsArray = new string[n];
                for (int i = 0; i < symbolsArray.Length; i++)
                {
                    symbolsArray[i] = symbols[i].ToString();
                }

               
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = symbolsArray[c];
                }
            }

            string symbolToFind = Console.ReadLine();
            bool isFound = false;

            int foundRow = 0;
            int foundCol = 0;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    string currentSymbol = matrix[r, c];
                    if(currentSymbol == symbolToFind)
                    {
                        isFound = true;
                        foundRow = r;
                        foundCol = c;
                        Console.WriteLine($"({foundRow}, {foundCol})");
                        break;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
            
        }
    }
}
