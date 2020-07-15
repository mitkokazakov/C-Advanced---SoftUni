using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwap
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();
                names.Add(currentLine);
                
            }

            Swap<string> swap = new Swap<string>(names);

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            swap.SwapItems(swap.Values, indexes[0], indexes[1]);

            Console.WriteLine(swap);
        }
    }
}
