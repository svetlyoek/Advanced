using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_queue_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int smallestElement = int.MaxValue;
            int numbersToEnqueue = operations[0];
            int numbersToDequeue = operations[1];
            int numberToPeek = operations[2];
           
            for(int i=0;i<numbersToDequeue;i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numberToPeek))
            {
                Console.WriteLine($"true");
            }
            else 
            {
                foreach(var number in queue)
                {
                    if(number<smallestElement)
                    {
                        smallestElement = number;
                    }
                }
                Console.WriteLine($"{smallestElement}");
            }
        }
    }
}
