using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToAdd = operations[0];
            int elementsToRemove = operations[1];
            int targetElement = operations[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> nums = new Queue<int>();

            for (int i = 0; i < elementsToAdd; i++)
            {
                nums.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                nums.Dequeue();
            }

            

            if (nums.Any())
            {
                if (nums.Contains(targetElement))
                {
                    Console.WriteLine("true");
                }
                else if (!nums.Contains(targetElement))
                {
                    Console.WriteLine(nums.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
