using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input != "Paid")
                {
                    customers.Enqueue(input);
                }
                else if (input == "Paid")
                {
                    Console.WriteLine(String.Join(Environment.NewLine, customers));
                    customers.Clear();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remainng");
        }
    }
}
