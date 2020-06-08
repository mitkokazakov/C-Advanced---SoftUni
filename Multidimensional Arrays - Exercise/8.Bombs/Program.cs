using System;
using System.Linq;
using System.Collections.Generic;

namespace _8.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            FillMatrix(size, matrix);

            string[] coordinates = Console.ReadLine().Split();

            for (int i = 0; i < coordinates.Length; i++)
            {
                string[] currentCoordinates = coordinates[i].Split(",");
                int bombRow = int.Parse(currentCoordinates[0]);
                int bombCol = int.Parse(currentCoordinates[1]);

                if (IsInBounds(bombRow, bombCol, size) && matrix[bombRow, bombCol] > 0)
                {
                    int currentCellValue = matrix[bombRow, bombCol];
                    matrix[bombRow, bombCol] = 0;

                    if (IsInBounds(bombRow + 1, bombCol, size) && matrix[bombRow + 1, bombCol] > 0)
                    {
                        matrix[bombRow + 1, bombCol] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow - 1, bombCol, size) && matrix[bombRow - 1, bombCol] > 0)
                    {
                        matrix[bombRow - 1, bombCol] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow, bombCol + 1, size) && matrix[bombRow, bombCol + 1] > 0)
                    {
                        matrix[bombRow, bombCol + 1] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow, bombCol - 1, size) && matrix[bombRow, bombCol - 1] > 0)
                    {
                        matrix[bombRow, bombCol - 1] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow + 1, bombCol + 1, size) && matrix[bombRow + 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol + 1] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow + 1, bombCol - 1, size) && matrix[bombRow + 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow + 1, bombCol - 1] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow - 1, bombCol + 1, size) && matrix[bombRow - 1, bombCol + 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol + 1] -= currentCellValue;
                    }
                    if (IsInBounds(bombRow - 1, bombCol - 1, size) && matrix[bombRow - 1, bombCol - 1] > 0)
                    {
                        matrix[bombRow - 1, bombCol - 1] -= currentCellValue;
                    }
                }
            }

            int sumALiveCells = 0;
            int countAliveCells = 0;

            foreach (var element in matrix)
            {
                if (element > 0)
                {
                    countAliveCells++;
                    sumALiveCells += element;
                }
            }

            Console.WriteLine($"Alive cells: {countAliveCells}");
            Console.WriteLine($"Sum: {sumALiveCells}");
            PrintMatrix(size, matrix);
        }

        private static void PrintMatrix(int size, int[,] matrix)
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

        private static void FillMatrix(int size, int[,] matrix)
        {
            for (int row = 0; row < size; row++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }

        private static bool IsInBounds(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
