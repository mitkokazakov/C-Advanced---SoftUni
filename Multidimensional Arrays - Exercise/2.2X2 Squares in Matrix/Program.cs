using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
   C# Advanced Exam - 26 October 2019 class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            int n = 2;

            int counter = 0;

            FillMatrix(rows, cols, matrix);

            for (int row = 0; row <= rows - n; row++)
            {
                for (int col = 0; col <= cols - n; col++)
                {

                   
                    if (IsAllEqual(matrix, row, col))
                    {
                        counter++;
                    }




                }
            }

            Console.WriteLine(counter);


        }

        private static void FillMatrix(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                char[] currentLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }
        }

        private static bool IsAllEqual(char[,] matrix, int row, int col)
        {
            char currentElement = matrix[row, col];
            return currentElement == matrix[row, col + 1] && currentElement == matrix[row + 1, col] && currentElement == matrix[row + 1, col + 1];
        }
    }
}

