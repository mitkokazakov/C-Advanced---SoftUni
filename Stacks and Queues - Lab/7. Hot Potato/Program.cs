using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> potato = new Queue<string>(names);

            int counter = 0;

            while (potato.Count > 1)
            {
                counter++;
                if (counter != n)
                {
                    string kidGoesToEnd = potato.Dequeue();
                    potato.Enqueue(kidGoesToEnd);
                }
                else
                {
                    Console.WriteLine($"Removed {potato.Dequeue()}");
                    counter = 0;
                }
           
            }

            Console.WriteLine($"Last is {potato.Dequeue()}");
        }
    }
}
