using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneBulletprice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] allBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] allLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(allBullets);
            Queue<int> locks = new Queue<int>(allLocks);
            int bulletCounter = 0;
            int earnedMoney = 0;
            int shootCounter = 0;
            while (bullets.Count > 0 || locks.Count > 0)
            {
               
               
                if (bullets.Peek() <= locks.Peek())
                {
                    shootCounter++;
                    Console.WriteLine($"Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                    bulletCounter++;
                }
                else
                {
                    shootCounter++;
                    Console.WriteLine($"Ping!");
                    bullets.Pop();
                    bulletCounter++;
                }
                if (shootCounter == gunBarrelSize && bullets.Count > 0)
                {
                    Console.WriteLine($"Reloading!");
                    shootCounter = 0;
                }
                if (bullets.Count>=0&&locks.Count==0)
                {
                    earnedMoney = intelligence - (bulletCounter * oneBulletprice);
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnedMoney}");
                    return;

                }
                else if (locks.Any()&&bullets.Count==0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }

            }
        }
    }
}