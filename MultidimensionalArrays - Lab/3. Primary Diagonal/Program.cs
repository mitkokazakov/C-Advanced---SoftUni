using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[numOfRowsAndCols, numOfRowsAndCols];

            DefineMatrix(numOfRowsAndCols, matrix);

            int sum = 0;

            sum = SumMainDiagonal(matrix, sum);

            Console.WriteLine(sum);
        }

        private static int SumMainDiagonal(int[,] matrix, int sum)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    // ternar operator
                    sum += row == col ? matrix[row, col] : 0;

                    //if (row == col)
                    //{
                    //    sum += matrix[row, col];
                    //}
                }
            }

            return sum;
        }

        private static void DefineMatrix(int numOfRowsAndCols, int[,] matrix)
        {
            for (int currentRow = 0; currentRow < numOfRowsAndCols; currentRow++)
            {
                int[] singleRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int currentCol = 0; currentCol < numOfRowsAndCols; currentCol++)
                {
                    matrix[currentRow, currentCol] = singleRow[currentCol];
                }
            }
        }
    }
}
