using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //Action<int[]> printArray = array =>
            //{
            //    Console.WriteLine(String.Join(Environment.NewLine,array));
            //};

            Func<int[], int> findMinNumber = arr =>
             {
                 int minValue = int.MaxValue;

                 foreach (var num in arr)
                 {
                     if (num < minValue)
                     {
                         minValue = num;
                     }
                 }

                 return minValue;
             };

            int minNum = findMinNumber(nums);
            Console.WriteLine(minNum);
            //printArray(nums);
        }
    }
}
