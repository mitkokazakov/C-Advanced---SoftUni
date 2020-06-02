using System;
using System.Linq;

namespace _5._1__Square_with_Maximum_Sum_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = GetInput();

            int rows = dimension[0];
            int cols = dimension[1];

            int[,] matrix = new int[rows, cols];

            DefineMatrix(rows, cols, matrix);

            int n = 3;

            int[,] currentMatrix = new int[n, n];

            int counterRows = -1;
            int counterCols = -1;
            bool isEndOfCol = false;
            int lastIndexOfCol = 0;

            for (int i = 0; i < rows; i++)
            {
                counterRows++;

                for (int j = lastIndexOfCol; j < cols; j++)
                {
                    counterCols++;
                    //lastIndexOfCol++;

                    currentMatrix[counterRows, counterCols] = matrix[i, j];

                    if (j == cols-1)
                    {
                        isEndOfCol = true;
                    }
                    if (counterCols == n-1)
                    {
                        counterCols = -1;
                        break;
                    }
                }

                if (isEndOfCol && counterRows == n-1)
                {
                    lastIndexOfCol = 0;
                    i = i - n + 1;
                    counterRows = -1;
                    PrintMatrix(n, n, currentMatrix);
                    isEndOfCol = false;
                }
                else if (counterRows == n-1)
                {
                    lastIndexOfCol += 1; //i + n - 2;
                    counterRows = -1;
                    i = i-n;
                    PrintMatrix(n, n, currentMatrix);
                }

                
            }

            //PrintMatrix(rows, cols, matrix);
        }

        private static void PrintMatrix(int rows, int cols, int[,] matrix)
        {
            for (int printRow = 0; printRow < rows; printRow++)
            {
                for (int printCol = 0; printCol < cols; printCol++)
                {
                    Console.Write(matrix[printRow, printCol] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void DefineMatrix(int rows, int cols, int[,] matrix)
        {
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                int[] currentLine = GetInput();

                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    matrix[currentRow, currentCol] = currentLine[currentCol];
                }
            }
        }

        private static int[] GetInput()
        {
            return Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        }
    }
}
