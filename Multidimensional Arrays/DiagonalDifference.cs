using System;
using System.Linq;
using System.Security.Principal;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] currRow = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
                

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                }
            }

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < size; i++)
            {
                firstSum += matrix[i, i];
            }
            for (int i = size - 1; i >= 0; i--)
            {
                secondSum += matrix[size-1-i, i];
            }
            int total = Math.Abs(firstSum - secondSum);
            Console.WriteLine(total);
        }
    }
}
