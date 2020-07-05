using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxLen = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> lessOrEqualThanLen = new Predicate<string>(name => name.Length <= maxLen);

            foreach (var name in names)
            {
                if (lessOrEqualThanLen(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
