using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> elements = new Stack<int>();

            int[] inputInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToPush = inputInfo[0];
            int elementsToPop = inputInfo[1];
            int targetNum = inputInfo[2];
            bool elementFound = false;

            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < elementsToPush; i++)
            {
                elements.Push(sequence[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                elements.Pop();
            }

            if (elements.Contains(targetNum))
            {
                elementFound = true;
            }

            if (elements.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (elementFound)
            {
                Console.WriteLine("true");
            }
            else if (!elementFound)
            {
                Console.WriteLine(elements.Min()); 
            }
        }
    }
}
