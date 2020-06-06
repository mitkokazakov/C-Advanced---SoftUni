using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[numOfRows, numOfRows];

            FillMatrix(numOfRows, matrix);

            int sumPrimaryDiagonal = SumPrimaryDiagonal(numOfRows, matrix);
            int sumSecondaryDiagonal = SumSecondaryDiagonal(numOfRows,matrix);

            int diff = Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal);
            Console.WriteLine(diff);

        }

        private static int SumSecondaryDiagonal(int numOfRows, int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < numOfRows; row++)
            {
                for (int col = 0; col < numOfRows; col++)
                {
                    if (col == numOfRows - row - 1)
                    {
                        sum += matrix[row, numOfRows - row - 1];
                    }
                }
            }

            return sum;
        }

        private static int SumPrimaryDiagonal(int numOfRows, int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < numOfRows; row++)
            {
                for (int col = 0; col < numOfRows; col++)
                {
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            return sum;
        }

        private static void FillMatrix(int numOfRows, int[,] matrix)
        {
            for (int currentRow = 0; currentRow < numOfRows; currentRow++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int currentCol = 0; currentCol < numOfRows; currentCol++)
                {
                    matrix[currentRow, currentCol] = currentLine[currentCol];
                }
            }
        }
    }
}
