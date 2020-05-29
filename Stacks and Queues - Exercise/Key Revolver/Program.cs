using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bulletsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> locks = new Queue<int>(locksArr);
            Stack<int> bullets = new Stack<int>(bulletsArr);

            int countShots = 0;


            while (true)
            {
                

                if (!locks.Any() || !bullets.Any())
                {
                    if (countShots == barrelSize && bullets.Any())
                    {
                        Console.WriteLine("Reloading!");
                    }
                    break;
                }

                int currentLock = locks.Peek();
                int currentBullet = bullets.Peek();

                if (countShots == barrelSize)
                {
                    Console.WriteLine("Reloading!");
                    countShots = 0;
                }

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                    countShots++;
                    intelligence -= bulletPrice;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    countShots++;
                    intelligence -= bulletPrice;
                }
            }

            if (!bullets.Any() && locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else if (bullets.Any() && !locks.Any())
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence}");
            }
        }
    }
}
