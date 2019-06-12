using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_stack_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallestElement = int.MaxValue;
            Stack<int> stack = new Stack<int>(numbers);
            int numbersToPush = operations[0];
            int numbersToPop = operations[1];
            int numberToPeek = operations[2];
           for(int i=0;i<numbersToPop;i++)
            {
                stack.Pop();
            }
           if(stack.Count==0)
            {
                Console.WriteLine(0);
            }
           else if(stack.Contains(numberToPeek))
            {
                Console.WriteLine($"true");
            }
            else
            {
                foreach(var number in stack)
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
