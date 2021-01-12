using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            var coordinates = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currCoordinates = coordinates[i].Split(",").Select(int.Parse).ToArray();
                int row = currCoordinates[0];
                int col = currCoordinates[1];


                if (matrix[row, col] <= 0) 
                {
                    continue;
                }
                
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                {
                    //upperpart
                    if (row - 1 >= 0 && col - 1 >= 0 && matrix[row - 1, col - 1] > 0)
                    {
                        matrix[row - 1, col - 1] -= matrix[row, col];
                    }
                    if (row - 1 >= 0 && matrix[row - 1, col] > 0)
                    {
                        matrix[row - 1, col] -= matrix[row, col];
                    }
                    if (row - 1 >= 0 && col + 1 < matrix.GetLength(1) && matrix[row - 1, col + 1] > 0)
                    {
                        matrix[row - 1, col + 1] -= matrix[row, col];
                    }
                    //mid part
                    if (col - 1 >= 0 && matrix[row, col - 1] > 0)
                    {
                        matrix[row, col - 1] -= matrix[row, col];
                    }
                    if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] > 0)
                    {
                        matrix[row, col + 1] -= matrix[row, col];
                    }
                    //down part
                    if (row + 1 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row + 1, col - 1] > 0)
                    {
                        matrix[row + 1, col - 1] -= matrix[row, col];
                    }
                    if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] > 0)
                    {
                        matrix[row + 1, col] -= matrix[row, col];
                    }
                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row + 1, col + 1] > 0)
                    {
                        matrix[row + 1, col + 1] -= matrix[row, col];
                    }
                    matrix[row, col] = 0;
                }


            }


            int aliveCells = 0;
            int sumAlive = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sumAlive += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumAlive}");
            PrintMatrix(n, matrix);
        }



        private static void PrintMatrix(int n, int[,] matrix)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == n - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }


                }
                Console.WriteLine();
            }
        }
    }
}

