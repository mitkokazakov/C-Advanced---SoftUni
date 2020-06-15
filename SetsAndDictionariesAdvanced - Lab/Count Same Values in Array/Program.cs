using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> countSameValues = new Dictionary<double, int>();

            foreach (var number in input)
            {
                if (!countSameValues.ContainsKey(number))
                {
                    countSameValues[number] = 0;
                }

                countSameValues[number]++;
            }

            foreach (var (key,value) in countSameValues)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
