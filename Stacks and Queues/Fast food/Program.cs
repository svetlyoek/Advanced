using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine($"{queue.Max()}");
            while (queue.Count > 0)
            {
                var currentOrder = queue.Peek();
                if (foodQuantity - currentOrder >= 0)
                {

                    foodQuantity -= currentOrder;
                    queue.Dequeue();
                }
                else
                {
                    Console.Write($"Orders left: {string.Join(" ", queue)}");
                    return;
                }

            }

            Console.WriteLine($"Orders complete");

        }
    }
}
