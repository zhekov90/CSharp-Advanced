using System;
using System.Text;

namespace Book_Worm
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int playerRow = -1;
            int playerCol = -1;
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {

                string currRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currRow[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                int previousRow = playerRow;
                int previousCol = playerCol;

                bool isInside = true;
                MovePlayer(ref playerRow, ref playerCol, command);
                if (playerRow < 0 || playerRow > matrix.GetLength(0) - 1 || playerCol < 0 || playerCol > matrix.GetLength(1) - 1)
                {
                    isInside = false;

                }

                if (isInside)
                {
                    if (matrix[playerRow, playerCol] != '-' && matrix[playerRow, playerCol] != 'P')
                    {
                        char currChar = matrix[playerRow, playerCol];
                        matrix[playerRow, playerCol] = 'P';
                        input.Append(currChar);
                        matrix[previousRow, previousCol] = '-';
                    }
                    else if (matrix[playerRow, playerCol] == '-' && matrix[playerRow, playerCol] != 'P')
                    {
                        matrix[playerRow, playerCol] = 'P';
                        matrix[previousRow, previousCol] = '-';
                    }
                }
                else
                {
                    input.Remove(input.Length - 1, 1);
                    playerRow = previousRow;
                    playerCol = previousCol;

                }


                command = Console.ReadLine();
            }

            Console.WriteLine(input);


            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void MovePlayer(ref int playerRow, ref int playerCol, string command)
        {
            switch (command)
            {
                case "up":

                    playerRow--;
                    break;
                case "down":

                    playerRow++;
                    break;
                case "left":

                    playerCol--;
                    break;
                case "right":

                    playerCol++;
                    break;
            }
        }
    }
}
