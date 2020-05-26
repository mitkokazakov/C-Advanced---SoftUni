using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {

            //5 4 8 6 3 8 7 7 9

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(input);

            int currentSum = 0;

            int numOfRacksNeeded = 0;

            while (clothes.Count > 1)
            {
                
                if ((currentSum + clothes.Peek()) <= capacityOfRack)
                {
                    currentSum += clothes.Pop();
                }
                
                else
                {
                    numOfRacksNeeded++;
                    currentSum = 0;
                }
            }

            if ((currentSum + clothes.Peek()) <= capacityOfRack)
            {
                numOfRacksNeeded++;
                clothes.Pop();
            }
            else
            {
                numOfRacksNeeded += 2;
                clothes.Pop();
            }

            Console.WriteLine(numOfRacksNeeded);
        }
    }
}
