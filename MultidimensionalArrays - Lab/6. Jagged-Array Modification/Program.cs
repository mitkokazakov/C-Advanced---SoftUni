using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());

            int[][] jaggedArr = new int[numRows][];

            FillJaggedArray(numRows, jaggedArr);

            string commands = Console.ReadLine();

            while (commands != "END")
            {
                string[] commandArgs = commands.Split();
                string mainCommand = commandArgs[0];

                int row = int.Parse(commandArgs[1]);
                int col = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);
                bool invalidCoordinates = row < 0 || row >= numRows || col < 0 || col >= jaggedArr[row].Length;

                if (invalidCoordinates)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (mainCommand == "Add")
                {
                    AddValue(jaggedArr, row, col, value);

                }
                else if (mainCommand == "Subtract")
                {
                    SubtractValue(jaggedArr, row, col, value);
                }

                commands = Console.ReadLine();
            }

            PrintJaggedArray(jaggedArr);
        }

        private static void SubtractValue(int[][] jaggedArr, int row, int col, int value)
        {
            jaggedArr[row][col] -= value;
        }

        private static void AddValue(int[][] jaggedArr, int row, int col, int value)
        {
            jaggedArr[row][col] += value;
        }

        private static void FillJaggedArray(int numRows, int[][] jaggedArr)
        {
            for (int currentRow = 0; currentRow < numRows; currentRow++)
            {
                int[] currentArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArr[currentRow] = currentArr;
            }
        }

        private static void PrintJaggedArray(int[][] jaggedArr)
        {
            foreach (int[] currentRow in jaggedArr)
            {
                Console.WriteLine(String.Join(" ", currentRow));
            }
        }
    }
}
