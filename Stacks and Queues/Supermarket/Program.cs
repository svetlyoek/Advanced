using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            int count = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(names);
            int counter = 1;
            while (queue.Count > 1)
            {
                if (counter == count)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                counter++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
