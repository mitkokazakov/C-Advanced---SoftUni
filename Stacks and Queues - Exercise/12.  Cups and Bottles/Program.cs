using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.__Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottles = new Stack<int>(inputBottles);
            Queue<int> cups = new Queue<int>(inputCups);
            
            int wastedWater = 0;

            while (bottles.Any() || cups.Any())
            {

                if (bottles.Count <= 0 || cups.Count <= 0)
                {
                    break;
                }
                int currentBottle = bottles.Peek();
                int currentCup = cups.Peek();
                int fillCup = 0;

                if (currentBottle >= currentCup)
                {
                    bottles.Pop();
                    cups.Dequeue();
                    wastedWater += currentBottle - currentCup;
                }
                else
                {
                    fillCup = currentCup - currentBottle;
                    bottles.Pop();

                    while (fillCup != 0)
                    {
                        int newCurrentBottle = bottles.Peek();

                        if (newCurrentBottle >= fillCup)
                        {
                            wastedWater += newCurrentBottle - fillCup;
                            bottles.Pop();
                            cups.Dequeue();
                            fillCup = 0;
                        }
                        else
                        {
                            fillCup = fillCup - bottles.Peek();
                            bottles.Pop();
                        }
                        
                        
                    }
                }
            }

            if (bottles.Count > cups.Count)
            {
                Console.WriteLine($"Bottles: {String.Join(" ",bottles)}");
            }
            else if (cups.Count > bottles.Count)
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
