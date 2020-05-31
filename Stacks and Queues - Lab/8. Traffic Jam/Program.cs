using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> trafficJam = new Queue<string>();

            int counterPassedCars = 0;

            while (input != "end")
            {
                if (input != "green")
                {
                    trafficJam.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < n && trafficJam.Any(); i++)
                    {
                        Console.WriteLine($"{trafficJam.Dequeue()} passed!");
                        counterPassedCars++;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counterPassedCars} cars passed the crossroads.");
        }
    }
}
