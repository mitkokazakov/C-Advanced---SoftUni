using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._1_Find_Evens_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string query = Console.ReadLine();
            List<int> output = new List<int>();

            Predicate<int> oddOrEven = null;

            if (query == "even")
            {
                oddOrEven = new Predicate<int>(n => n % 2 == 0);
            }
            else
            {
                oddOrEven = new Predicate<int>(n => n % 2 != 0);
            }

            for (int i = range[0]; i <= range[1]; i++)
            {
                if (oddOrEven(i))
                {
                    output.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ",output));
        }
    }
}
