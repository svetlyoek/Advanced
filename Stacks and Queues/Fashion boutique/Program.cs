using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oneRackCapacity = int.Parse(Console.ReadLine());
            int racksCounter = 1;
            int sum = 0;
            Stack<int> rack = new Stack<int>(clothes);
          while(rack.Any())
            {
                var currentClothes = rack.Peek();
                if(sum+currentClothes<=oneRackCapacity)
                {
                    sum += currentClothes;
                    rack.Pop();
                }
                else
                {
                    racksCounter++;
                   
                    sum = 0;
                }
            }
            Console.WriteLine(racksCounter);

        }
    }
}
