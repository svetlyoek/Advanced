using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<int> indexes = new Queue<int>();
            int fuel = 0;
            for(int i=0;i<pumps;i++)
            {
                int[] fuelAndDistance = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int currentFuel = fuelAndDistance[0];
                int currentDistance = fuelAndDistance[1];
                fuel += currentFuel;
                if(fuel>=currentDistance)
                {
                    indexes.Enqueue(i);
                    fuel -= currentDistance;
                }
                else
                {
                    indexes.Clear();
                    fuel = 0;
                }
            }
            Console.WriteLine(indexes.Dequeue());
        }
    }
}
