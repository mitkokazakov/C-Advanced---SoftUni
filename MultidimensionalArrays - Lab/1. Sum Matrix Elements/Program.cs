using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputColRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = inputColRow[0];
            int cols = inputColRow[1];

            int[,] matrix = new int[rows,cols];

            //Fill the matrix with elements
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] singleRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = singleRow[col];
                }
            }

            //Print the matrix
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(matrix[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Sum all elements of the matrix
            int sum = 0;

            foreach (var elememt in matrix)
            {
                sum += elememt;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
