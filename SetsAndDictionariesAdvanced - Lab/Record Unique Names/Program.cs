using System;
using System.Collections.Generic;
using System.Linq;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFLInes = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numOFLInes; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(String.Join(Environment.NewLine,names));
        }
    }
}
