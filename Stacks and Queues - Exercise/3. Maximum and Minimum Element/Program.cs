using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> elements = new Stack<int>();

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int mainCommand = commands[0];

                if (mainCommand == 1)
                {
                    int elementToPush = commands[1];
                    elements.Push(elementToPush);
                }
                else if (mainCommand == 2)
                {
                    if (elements.Any())
                    {
                        elements.Pop();
                    }
                    
                }
                else if (mainCommand == 3)
                {
                    if (elements.Any())
                    {
                        Console.WriteLine(elements.Max());
                    }
                    
                }
                else if (mainCommand == 4)
                {
                    if (elements.Any())
                    {
                        Console.WriteLine(elements.Min());
                    }
                }
            }

            //while (elements.Count != 0)
            //{
            //    Console.Write(elements.Pop() + " ");
            //}

            Console.WriteLine(String.Join(", ",elements));
        }
    }
}
