using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            ReadMatrix(size, matrix);

            int currentKnightAttacks = 0;
            int bestKnightAttacks = 0;
            int bestKnightRow = 0;
            int bestKnightCol = 0;
            int counterKnights = 0;

            while (true)
            {
                bestKnightAttacks = 0;

                for (int currentRow = 0; currentRow < size; currentRow++)
                {
                    for (int currentCol = 0; currentCol < size; currentCol++)
                    {
                        if (matrix[currentRow, currentCol] == 'K')
                        {
                            if (IsInside(currentRow - 2, currentCol + 1, matrix) && matrix[currentRow - 2, currentCol + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow - 2, currentCol - 1, matrix) && matrix[currentRow - 2, currentCol - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow - 1, currentCol + 2, matrix) && matrix[currentRow - 1, currentCol + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow - 1, currentCol - 2, matrix) && matrix[currentRow - 1, currentCol - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow + 1, currentCol + 2, matrix) && matrix[currentRow + 1, currentCol + 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow + 1, currentCol - 2, matrix) && matrix[currentRow + 1, currentCol - 2] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow + 2, currentCol + 1, matrix) && matrix[currentRow + 2, currentCol + 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                            if (IsInside(currentRow + 2, currentCol - 1, matrix) && matrix[currentRow + 2, currentCol - 1] == 'K')
                            {
                                currentKnightAttacks++;
                            }
                        }

                        if (currentKnightAttacks > bestKnightAttacks)
                        {
                            bestKnightAttacks = currentKnightAttacks;
                            bestKnightRow = currentRow;
                            bestKnightCol = currentCol;
                        }

                        currentKnightAttacks = 0;
                    }
                }

                if (bestKnightAttacks != 0)
                {
                    matrix[bestKnightRow, bestKnightCol] = '0';
                    counterKnights++;
                }
                else
                {
                    Console.WriteLine(counterKnights);
                    break;
                }
                
            }
        }

        private static bool IsInside(int row, int col, char[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static void ReadMatrix(int size, char[,] matrix)
        {
            for (int currentRow = 0; currentRow < size; currentRow++)
            {
                string currentLine = Console.ReadLine();

                for (int currentCol = 0; currentCol < size; currentCol++)
                {
                    matrix[currentRow, currentCol] = currentLine[currentCol];
                }
            }
        }
    }
}
