using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[numOfRows][];

            ReadIntegerjaggedArray(numOfRows, jaggedArr);

            AnalyzingTheJaggedArray(numOfRows, jaggedArr);

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] commandsArgs = commands.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string mainCommand = commandsArgs[0];

                if (mainCommand == "Add")
                {
                    AddValueToTheGivenElement(numOfRows, jaggedArr, commandsArgs);
                }
                else if (mainCommand == "Subtract")
                {
                    SubtractValueFromTheGivenElement(numOfRows, jaggedArr, commandsArgs);
                }

                commands = Console.ReadLine();
            }

            PrintJaggedArray(jaggedArr);
        }

        private static void SubtractValueFromTheGivenElement(int numOfRows, double[][] jaggedArr, string[] commandsArgs)
        {
            int row = int.Parse(commandsArgs[1]);
            int col = int.Parse(commandsArgs[2]);
            double value = double.Parse(commandsArgs[3]);

            if (row >= 0 && row < numOfRows && col >= 0 && col < jaggedArr[row].Length)
            {
                jaggedArr[row][col] -= value;
            }
        }

        private static void AddValueToTheGivenElement(int numOfRows, double[][] jaggedArr, string[] commandsArgs)
        {
            int row = int.Parse(commandsArgs[1]);
            int col = int.Parse(commandsArgs[2]);
            double value = double.Parse(commandsArgs[3]);

            if (row >= 0 && row < numOfRows && col >= 0 && col < jaggedArr[row].Length)
            {
                jaggedArr[row][col] += value;
            }
        }

        private static void AnalyzingTheJaggedArray(int numOfRows, double[][] jaggedArr)
        {
            for (int currentRow = 0; currentRow < numOfRows - 1; currentRow++)
            {
                if (jaggedArr[currentRow].Length == jaggedArr[currentRow + 1].Length)
                {
                    for (int i = 0; i < jaggedArr[currentRow].Length; i++)
                    {
                        jaggedArr[currentRow][i] *= 2;
                    }

                    for (int j = 0; j < jaggedArr[currentRow + 1].Length; j++)
                    {
                        jaggedArr[currentRow + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArr[currentRow].Length; i++)
                    {
                        jaggedArr[currentRow][i] /= 2;
                    }

                    for (int j = 0; j < jaggedArr[currentRow + 1].Length; j++)
                    {
                        jaggedArr[currentRow + 1][j] /= 2;
                    }
                }
            }
        }

        private static void PrintJaggedArray(double[][] jaggedArr)
        {
            foreach (var row in jaggedArr)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }

        private static void ReadIntegerjaggedArray(int numOfRows, double[][] jaggedArr)
        {
            for (int currentRow = 0; currentRow < numOfRows; currentRow++)
            {
                double[] currentArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                jaggedArr[currentRow] = currentArr;
            }
        }
    }
}
