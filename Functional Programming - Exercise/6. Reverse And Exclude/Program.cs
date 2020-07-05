using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int numToDivide = int.Parse(Console.ReadLine());
            List<int> outputNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                Predicate<int> predicate = n => n % numToDivide != 0;

                if (predicate(nums[i]))
                {
                    outputNums.Add(nums[i]);
                }
            }

            outputNums.Reverse();
            Console.WriteLine(String.Join(" ",outputNums));
        }
    }
}
