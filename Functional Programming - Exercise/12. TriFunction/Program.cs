using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> succesNames = new List<string>();

            Func<string, int, bool> IsSumLargerOrEqual = (name, sum) =>
              {
                  int currentSum = 0;

                  foreach (var letter in name)
                  {
                      currentSum += letter;
                  }

                  return currentSum >= sum;
              };

            foreach (var name in names)
            {
                if (IsSumLargerOrEqual(name,n))
                {
                    succesNames.Add(name);
                }
            }

            Console.WriteLine(succesNames.First());
        }
    }
}
