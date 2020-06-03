using System;
using System.Linq;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[numOfRows][];

            if (numOfRows == 1)
            {
                pascalTriangle[0] = new long[] { 1 };
            }
            else if (numOfRows == 2)
            {
                pascalTriangle[0] = new long[] { 1 };
                pascalTriangle[1] = new long[] { 1, 1 };
            }
            else
            {
                pascalTriangle[0] = new long[] { 1 };
                pascalTriangle[1] = new long[] { 1, 1 };

                for (int currentRow = 2; currentRow < numOfRows; currentRow++)
                {
                    pascalTriangle[currentRow] = new long[currentRow+1];
                    pascalTriangle[currentRow][0] = 1;
                    pascalTriangle[currentRow][currentRow] = 1;

                    for (int currentCol = 1; currentCol < currentRow; currentCol++)
                    {
                        pascalTriangle[currentRow][currentCol] = pascalTriangle[currentRow - 1][currentCol - 1] + pascalTriangle[currentRow - 1][currentCol];
                    }
                }
            }

            PrintPascalTriangle(pascalTriangle);
        }

        private static void PrintPascalTriangle(long[][] pascalTriangle)
        {
            foreach (long[] currentRow in pascalTriangle)
            {
                Console.WriteLine(String.Join(" ", currentRow));
            }
        }
    }
}
