using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int totalFood = int.Parse(Console.ReadLine());
            int[] ordersArr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(ordersArr);

            int maxOrder = orders.Max();

            Console.WriteLine(maxOrder);

            bool check = false;

            while (orders.Any())
            {
                int currentOrder = orders.Peek();

                if (currentOrder <= totalFood)
                {
                    totalFood -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    Console.Write("Orders left: ");
                    Console.WriteLine(String.Join(" ", orders));
                    check = true;
                    break;
                }
            }

            if (!check)
            {
                Console.WriteLine("Orders complete");
            }
            
        }
    }
}
