using System;
using System.Linq;
using System.Collections.Generic;

namespace _9._List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endOffRange = int.Parse(Console.ReadLine());
            List<int> dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> outpuutNums = new List<int>();

            bool isDivisible = true;

            for (int i = 1; i <= endOffRange; i++)
            {
                int currentNum = i;

                foreach (var divider in dividers)
                {
                    Predicate<int> division = n => currentNum % n == 0;

                    if (division(divider))
                    {
                        isDivisible = true;
                    }
                    else
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible == true)
                {
                    outpuutNums.Add(currentNum);
                }
            }

            Console.WriteLine(String.Join(" ",outpuutNums));
        }
    }
}
