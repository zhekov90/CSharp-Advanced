using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

            int[,] matrix = new int[size[0], size[1]];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    int currSum = 0;
                    int startIndex = matrix[row, col];
                    
                        currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                        if (currSum > bestSum)
                        {
                            bestSum = currSum;
                            bestRow = row;
                            bestCol = col;
                        }

                }

            }
            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol+1]}");
            Console.WriteLine($"{matrix[bestRow+1, bestCol]} {matrix[bestRow+1, bestCol + 1]}");
            Console.WriteLine(bestSum);
        }
    }
}
