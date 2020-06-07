using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            ReadStringMatrix(rows, cols, matrix);

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] commandArgs = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs.Length != 5 || !commandArgs.Contains("swap") || commandArgs[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(commandArgs[1]);
                    int col1 = int.Parse(commandArgs[2]);
                    int row2 = int.Parse(commandArgs[3]);
                    int col2 = int.Parse(commandArgs[4]);

                    if (row1 >= rows || row1 < 0 || row2 >= rows || row2 < 0 || col1 >= cols || col1 < 0 || col2 >= cols || col2 < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string swap1 = matrix[row1, col1];
                        string swap2 = matrix[row2, col2];

                        matrix[row1, col1] = swap2;
                        matrix[row2, col2] = swap1;

                        PrintMatrix(rows, cols, matrix);

                    }
                }

                commands = Console.ReadLine();
            }
        }

        private static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    Console.Write(matrix[currentRow, currentCol] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadStringMatrix(int rows, int cols, string[,] matrix)
        {
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int currentCol = 0; currentCol < cols; currentCol++)
                {
                    matrix[currentRow, currentCol] = line[currentCol];
                }
            }
        }
    }
}
