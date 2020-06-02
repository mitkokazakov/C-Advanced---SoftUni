using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ParseInput();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            int[,] currentMatrix = new int[2, 2];
            int[,] bestMatrix = new int[2, 2];

            FillTheMatrix(matrix);

            int currentSum = 0;
            int bestSum = 0;

            for (int currentRow = 0; currentRow < matrix.GetLength(0) - 1; currentRow++)
            {
                
                for (int currentCol = 0; currentCol < matrix.GetLength(1) - 1; currentCol++)
                {
                    Define2x2Matrix(matrix, currentMatrix, currentRow, currentCol);
                    currentSum = SumElementsOFMatrix(currentMatrix);

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        Define2x2Matrix(matrix, bestMatrix,currentRow,currentCol);
                    }
                }
            }

            PrintMatrix(bestMatrix);
            Console.WriteLine(bestSum);


        }

        

        private static void Define2x2Matrix(int[,] matrix, int[,] currentMatrix, int currentRow, int currentCol)
        {
            currentMatrix[0, 0] = matrix[currentRow, currentCol];
            currentMatrix[0, 1] = matrix[currentRow, currentCol + 1];
            currentMatrix[1, 0] = matrix[currentRow + 1, currentCol];
            currentMatrix[1, 1] = matrix[currentRow + 1, currentCol + 1];
        }

        private static void FillTheMatrix(int[,] matrix)
        {
            for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
            {
                int[] singleLine = ParseInput();

                for (int currentCol = 0; currentCol < matrix.GetLength(1); currentCol++)
                {
                    matrix[currentRow, currentCol] = singleLine[currentCol];
                }
            }
        }

        private static int[] ParseInput()
        {
            return Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }

        private static void PrintMatrix(int[,] currentMAtrix)
        {
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write(currentMAtrix[r, c] + " ");
                }
                Console.WriteLine();
            }
        }

        private static int SumElementsOFMatrix(int[,] matrixToSum)
        {
            int sum = 0;

            foreach (var element in matrixToSum)
            {
                sum += element;
            }

            return sum;
        }
    }
}
