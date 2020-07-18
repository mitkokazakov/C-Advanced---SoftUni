using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> names = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake lake = new Lake(names);

            Console.WriteLine(String.Join(", ",lake));
        }
    }
}
