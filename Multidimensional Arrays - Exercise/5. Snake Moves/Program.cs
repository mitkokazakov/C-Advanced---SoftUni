using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string word = Console.ReadLine();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            int counter = 0;

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                if (currentRow % 2 == 0)
                {
                    for (int currentCol = 0; currentCol < cols; currentCol++)
                    {

                        counter = ZigZag(word, matrix, counter, currentRow, currentCol);
                    }
                }
                else
                {
                    for (int currentCol = cols - 1; currentCol >= 0; currentCol--)
                    {
                        counter = ZigZag(word, matrix, counter, currentRow, currentCol);

                    }
                }

            }

            PrintMatrix(rows, cols, matrix);
        }

        private static int ZigZag(string word, char[,] matrix, int counter, int currentRow, int currentCol)
        {
            matrix[currentRow, currentCol] = word[counter];
            counter++;

            if (counter > word.Length - 1)
            {
                counter = 0;
            }

            return counter;
        }

        private static void PrintMatrix(int rows, int cols, char[,] matrix)
        {
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    Console.Write(matrix[currentRow, currentCol]);
                }

                Console.WriteLine();
            }
        }
    }
}
