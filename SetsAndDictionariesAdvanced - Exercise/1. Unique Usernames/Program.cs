using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOffLines = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numOffLines; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(String.Join(Environment.NewLine,names));
        }
    }
}
