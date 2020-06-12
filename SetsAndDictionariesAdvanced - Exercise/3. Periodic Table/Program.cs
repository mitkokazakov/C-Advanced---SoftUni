using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            HashSet<string> periodicTable = new HashSet<string>();

            for (int i = 0; i < numOfLines; i++)
            {
                string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    periodicTable.Add(element);
                }
            }

            Console.WriteLine(String.Join(" ", periodicTable.OrderBy(x => x)));
        }
    }
}
