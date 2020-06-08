using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Data;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            List<int> bunnyCoordinates = new List<int>();

            FillMatrix(rows, matrix);



            string commands = Console.ReadLine();

            for (int i = 0; i < commands.Length; i++)
            {
                char currentDirection = commands[i];

                GetBuunnyCoordinates(rows, cols, matrix, bunnyCoordinates);

                int playerRow = 0;
                int playerCol = 0;

                int dieRow = 0;
                int dieCol = 0;

                GetPlayerCoordintates(rows, cols, matrix, ref playerRow, ref playerCol);

                bool playerEscape = false;
                bool bunnyFound = false;
                bool playerFound = false;

                if (currentDirection == 'U')
                {
                    int rowDirection = -1;
                    int colDirection = 0;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref playerEscape, ref bunnyFound, rowDirection, colDirection);

                    SpreadBunny(matrix, bunnyCoordinates, ref dieRow, ref dieCol, ref playerFound);
                }
                else if (currentDirection == 'D')
                {
                    int rowDirection = 1;
                    int colDirection = 0;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref playerEscape, ref bunnyFound, rowDirection, colDirection);

                    SpreadBunny(matrix, bunnyCoordinates, ref dieRow, ref dieCol, ref playerFound);
                }
                else if (currentDirection == 'L')
                {
                    int rowDirection = 0;
                    int colDirection = -1;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref playerEscape, ref bunnyFound, rowDirection, colDirection);

                    SpreadBunny(matrix, bunnyCoordinates, ref dieRow, ref dieCol, ref playerFound);
                }
                else if (currentDirection == 'R')
                {
                    int rowDirection = 0;
                    int colDirection = 1;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref playerEscape, ref bunnyFound, rowDirection, colDirection);

                    SpreadBunny(matrix, bunnyCoordinates, ref dieRow, ref dieCol, ref playerFound);
                }

                bunnyCoordinates = new List<int>();

                if (playerEscape)
                {
                    PrintMatrix(rows, cols, matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    break;
                }
                else if (bunnyFound)
                {
                    PrintMatrix(rows, cols, matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    break;
                }
                else if (playerFound)
                {
                    PrintMatrix(rows, cols, matrix);
                    Console.WriteLine($"dead: {dieRow} {dieCol}");
                    break;
                }
            }






        }

        private static void SpreadBunny(char[,] matrix, List<int> bunnyCoordinates, ref int dieRow, ref int dieCol, ref bool playerFound)
        {
            for (int m = 0; m < bunnyCoordinates.Count; m += 2)
            {
                int bunnyRow = bunnyCoordinates[m];
                int bunnyCol = bunnyCoordinates[m + 1];

                if (IsInBounds(bunnyRow + 1, bunnyCol, matrix))
                {
                    if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                    {
                        dieRow = bunnyRow + 1;
                        dieCol = bunnyCol;
                        playerFound = true;
                    }

                    matrix[bunnyRow + 1, bunnyCol] = 'B';
                }
                if (IsInBounds(bunnyRow - 1, bunnyCol, matrix))
                {
                    if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                    {
                        dieRow = bunnyRow - 1;
                        dieCol = bunnyCol;
                        playerFound = true;
                    }

                    matrix[bunnyRow - 1, bunnyCol] = 'B';
                }
                if (IsInBounds(bunnyRow, bunnyCol + 1, matrix))
                {
                    if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                    {
                        dieRow = bunnyRow;
                        dieCol = bunnyCol + 1;
                        playerFound = true;
                    }

                    matrix[bunnyRow, bunnyCol + 1] = 'B';
                }
                if (IsInBounds(bunnyRow, bunnyCol - 1, matrix))
                {
                    if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                    {
                        dieRow = bunnyRow;
                        dieCol = bunnyCol - 1;
                        playerFound = true;
                    }

                    matrix[bunnyRow, bunnyCol - 1] = 'B';
                }
            }
        }

        private static void MovingPlayer(char[,] matrix, ref int playerRow, ref int playerCol, ref bool bunnyEscape, ref bool bunnyFound, int rowDirection, int colDirection)
        {
            if (IsInBounds(playerRow + rowDirection, playerCol + colDirection, matrix) && matrix[playerRow + rowDirection, playerCol + colDirection] == 'B')
            {
                bunnyFound = true;
                playerRow += rowDirection;
                playerCol += colDirection;
            }
            else if (IsInBounds(playerRow + rowDirection, playerCol + colDirection, matrix) && matrix[playerRow + rowDirection, playerCol + colDirection] == '.')
            {
                matrix[playerRow + rowDirection, playerCol + colDirection] = 'P';
                matrix[playerRow, playerCol] = '.';
            }
            else if (!IsInBounds(playerRow + rowDirection, playerCol + colDirection, matrix))
            {
                bunnyEscape = true;
                matrix[playerRow, playerCol] = '.';
            }
        }

        private static void GetPlayerCoordintates(int rows, int cols, char[,] matrix, ref int playerRow, ref int playerCol)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }

        private static bool IsInBounds(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
        private static void GetBuunnyCoordinates(int rows, int cols, char[,] matrix, List<int> bunnyCoordinates)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunnyCoordinates.Add(row);
                        bunnyCoordinates.Add(col);
                    }
                }
            }
        }

        private static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static void FillMatrix(int rows, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string currentLine = Console.ReadLine();

                for (int col = 0; col < currentLine.Length; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }
    }
}
