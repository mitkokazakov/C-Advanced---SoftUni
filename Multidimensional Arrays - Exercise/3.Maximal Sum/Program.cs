using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            int n = 3;

            int bestRow = 0;
            int bestCol = 0;

            FillMatrix(rows, cols, matrix);

            int currentSum = 0;
            int bestSum = 0;

            for (int row = 0; row <= rows - n; row++)
            {
                for (int col = 0; col <= cols - n; col++)
                {
                    for (int subRow = row; subRow < n + row; subRow++)
                    {
                        for (int subCol = col; subCol < n + col; subCol++)
                        {
                            int currentElement = matrix[subRow, subCol];
                            currentSum += currentElement;
                        }
                    }

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                        currentSum = 0;
                    }
                    currentSum = 0;
                }
            }

            Console.WriteLine($"Sum = {bestSum}");

            for (int row = bestRow; row < n + bestRow; row++)
            {
                for (int col = bestCol; col < n + bestCol; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] currentLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }
    }
}
