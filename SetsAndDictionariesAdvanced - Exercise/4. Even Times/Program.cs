using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < numOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!counts.ContainsKey(number))
                {
                    counts[number] = 0;
                }

                counts[number]++;
            }

            foreach (var (key,value) in counts)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                }
            }
        }
    }
}
