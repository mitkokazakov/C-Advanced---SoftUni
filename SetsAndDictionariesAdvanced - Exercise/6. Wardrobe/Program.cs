using System;
using System.Linq;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int numOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ", 2);
                string color = input[0];
                string[] clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
                
            }

            string[] filter = Console.ReadLine().Split();
            string filterColor = filter[0];
            string filterItem = filter[1];

            foreach (var (color,clothes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var (item,count) in clothes)
                {
                    if (filterColor == color && filterItem == item)
                    {
                        Console.WriteLine($"* {item} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item} - {count}");
                    }
                }
            }
        }
    }
}
