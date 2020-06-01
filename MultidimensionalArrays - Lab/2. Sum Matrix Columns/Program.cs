﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputColRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = inputColRow[0];
            int cols = inputColRow[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] singleLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = singleLine[col];
                }
            }

            int currentSum = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                currentSum = 0;

                for (int h = 0; h < matrix.GetLength(0); h++)
                {
                    currentSum += matrix[h, i];
                }

                Console.WriteLine(currentSum);
            }
        }
    }
}
