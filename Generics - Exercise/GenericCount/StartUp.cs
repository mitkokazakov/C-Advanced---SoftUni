using System;
using System.Collections.Generic;

namespace GenericCount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                items.Add(line);
            }

            Count<string> count = new Count<string>(items);

            string elementToCompare = Console.ReadLine();

            int countOfGreaterElements = count.CountItems(count.Items, elementToCompare);

            Console.WriteLine(countOfGreaterElements);
        }
    }
}
