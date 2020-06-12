using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lenOfFirstSet = size[0];
            int lenOfSecondSet = size[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < lenOfFirstSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < lenOfSecondSet; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            foreach (var num in firstSet)
            {
                foreach (var number in secondSet)
                {
                    if (num == number)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
