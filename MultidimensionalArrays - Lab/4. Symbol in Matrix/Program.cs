using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRowsAndCols = int.Parse(Console.ReadLine());

            char[,] matrix = new char[numOfRowsAndCols, numOfRowsAndCols];


            FillMatrix(numOfRowsAndCols, matrix);

            char symbolToFind = char.Parse(Console.ReadLine());

            bool isFound = false;

            isFound = SearchSymbol(numOfRowsAndCols, matrix, symbolToFind, isFound);

            if (!isFound)
            {
                Console.WriteLine($"{symbolToFind} does not occur in the matrix");
            }
        }

        private static bool SearchSymbol(int numOfRowsAndCols, char[,] matrix, char symbolToFind, bool isFound)
        {
            for (int row = 0; row < numOfRowsAndCols; row++)
            {
                for (int col = 0; col < numOfRowsAndCols; col++)
                {
                    if (matrix[row, col] == symbolToFind)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }

            return isFound;
        }

        private static void FillMatrix(int numOfRowsAndCols, char[,] matrix)
        {
            for (int currentRow = 0; currentRow < numOfRowsAndCols; currentRow++)
            {
                string line = Console.ReadLine();

                for (int currentCol = 0; currentCol < numOfRowsAndCols; currentCol++)
                {
                    matrix[currentRow, currentCol] = line[currentCol];
                }
            }
        }
    }
}
