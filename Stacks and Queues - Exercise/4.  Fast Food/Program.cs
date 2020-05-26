using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.__Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(input);
            bool isEnoughFood = true;

            
            int biggestOrder = 0;
            int queueLen = orders.Count;

            if (orders.Any())
            {
                Console.WriteLine(orders.Max());
            }
            


            for (int i = 0; i < queueLen; i++)
            {
                int currentOrder = orders.Peek();

                if (currentOrder <= quantityOfFood)
                {
                    if (currentOrder > biggestOrder)
                    {
                        biggestOrder = currentOrder;
                    }
                    quantityOfFood -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(" ", orders)}");
                    isEnoughFood = false;
                }
            }

            
                
            
            

            if (orders.Count == 0 && isEnoughFood)
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}
