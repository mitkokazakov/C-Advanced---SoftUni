using System;
using System.Linq;
using System.Collections.Generic;

namespace _9.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            string[] directions = Console.ReadLine().Split();

            char[,] matrix = new char[size, size];

            FillMatrix(size, matrix);

            int playerRow = 0;
            int playerCol = 0;
            int coalsCount = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 'c')
                    {
                        coalsCount++;
                    }
                    else if (matrix[row, col] == 's')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            int currentColas = 0;
            int finalRow = 0;
            int finalCol = 0;

            bool endGame = false;
            bool collectAll = false;

            for (int i = 0; i < directions.Length; i++)
            {
                string currentDirection = directions[i];

                if (currentDirection == "up" && IsInBound(playerRow - 1, playerCol, size))
                {
                    int r = -1;
                    int c = 0;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref currentColas, ref finalRow, ref finalCol, r, c, ref endGame);

                    if (currentColas == coalsCount)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        break;
                    }
                    else if (endGame)
                    {
                        Console.WriteLine($"Game over! ({finalRow}, {finalCol})");
                        break;
                    }
                }
                else if (currentDirection == "down" && IsInBound(playerRow + 1, playerCol, size))
                {
                    int r = 1;
                    int c = 0;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref currentColas, ref finalRow, ref finalCol, r, c, ref endGame);

                    if (currentColas == coalsCount)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        break;
                    }
                    else if (endGame)
                    {
                        Console.WriteLine($"Game over! ({finalRow}, {finalCol})");
                        break;
                    }
                }
                else if (currentDirection == "left" && IsInBound(playerRow, playerCol - 1, size))
                {
                    int r = 0;
                    int c = -1;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref currentColas, ref finalRow, ref finalCol, r, c, ref endGame);

                    if (currentColas == coalsCount)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        break;
                    }
                    else if (endGame)
                    {
                        Console.WriteLine($"Game over! ({finalRow}, {finalCol})");
                        break;
                    }
                }
                else if (currentDirection == "right" && IsInBound(playerRow, playerCol + 1, size))
                {
                    int r = 0;
                    int c = 1;

                    MovingPlayer(matrix, ref playerRow, ref playerCol, ref currentColas, ref finalRow, ref finalCol, r, c, ref endGame);

                    if (currentColas == coalsCount)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        break;
                    }
                    else if (endGame)
                    {
                        Console.WriteLine($"Game over! ({finalRow}, {finalCol})");
                        break;
                    }
                }
            }

            if (!endGame && currentColas != coalsCount)
            {
                Console.WriteLine($"{coalsCount - currentColas} coals left. ({playerRow}, {playerCol})");
            }

            //PrintMatrix(size, matrix);
        }

        private static void MovingPlayer(char[,] matrix, ref int playerRow, ref int playerCol, ref int currentColas, ref int finalRow, ref int finalCol, int r, int c, ref bool end)
        {

            if (matrix[playerRow + r, playerCol + c] == 'c')
            {
                currentColas++;
                matrix[playerRow + r, playerCol + c] = '*';
                playerRow += r;
                playerCol += c;
                
            }
            else if (matrix[playerRow + r, playerCol + c] == 'e')
            {
                finalRow = playerRow + r;
                finalCol = playerCol + c;
                end = true;

            }
            else if (matrix[playerRow + r, playerCol + c] == '*' || matrix[playerRow + r, playerCol + c] == 's')
            {
                playerRow += r;
                playerCol += c;
            }
        }

        private static void PrintMatrix(int size, char[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int size, char[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                char[] currentLine = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }

        private static bool IsInBound(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
