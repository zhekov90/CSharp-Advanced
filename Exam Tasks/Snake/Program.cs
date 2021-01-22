using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static char[,] matrix;
        static int playerRow;
        static int playerCol;
        static bool isOutside;

        static int firstBRow;
        static int firstBCol;
        static int secondBRow;
        static int secondBCol;

        static bool foundB;
        static int food;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new char[size, size];

            firstBRow = -1;
            firstBCol = -1;
            secondBRow = -1;
            secondBCol = -1;
            food = 0;
            foundB = false;
            isOutside = false;

            FillTheMatrix();

            while (!isOutside && food < 10)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0); 
                        break;
                    case "left":
                        Move(0, -1); 
                        break;
                    case "right":
                        Move(0, 1); 
                        break;
                }
            }



            if (isOutside)
            {
                Console.WriteLine("Game over!");
            }
            else if (food == 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }
            Console.WriteLine($"Food eaten: {food}");


            PrintMatrix();
        }

        private static void PrintMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FillTheMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currRow[col];
                    if (matrix[row, col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    else if (matrix[row, col] == 'B')
                    {
                        if (!foundB)
                        {
                            firstBRow = row;
                            firstBCol = col;
                            foundB = true;
                        }
                        else
                        {
                            secondBRow = row;
                            secondBCol = col;
                        }
                    }
                }
            }
        }
        private static void Move(int row, int col)
        {
            if (IsInsideTheMatrix(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '.';

                if (matrix[playerRow + row, playerCol + col] == '*')
                {
                    food++;
                    matrix[playerRow + row, playerCol + col] = 'S';
                    playerRow += row;
                    playerCol += col;
                }
                else if (matrix[playerRow + row, playerCol + col] == 'B')
                {
                    matrix[playerRow + row, playerCol + col] = '.';

                    if (playerRow + row == firstBRow &&
                        playerCol + col == firstBCol)
                    {
                        matrix[secondBRow, secondBCol] = 'S';
                        playerRow = secondBRow;
                        playerCol = secondBCol;
                    }
                    else if (playerRow + row == secondBRow &&
                             playerCol + col == secondBCol)
                    {
                        matrix[firstBRow, firstBCol] = 'S';
                        playerRow = firstBRow;
                        playerCol = firstBCol;
                    }
                }
                else
                {
                    matrix[playerRow + row, playerCol + col] = 'S';
                    playerRow += row;
                    playerCol += col;
                }
            }
            else
            {
                matrix[playerRow, playerCol] = '.';
                isOutside = true;
            }
        }

        private static bool IsInsideTheMatrix(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
