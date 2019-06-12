using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int querys = int.Parse(Console.ReadLine());

            for (int i = 0; i < querys; i++)
            {
                var commands = Console.ReadLine()
                    .Split();
                if (commands[0] == "1")
                {
                    int number = int.Parse(commands[1]);
                    stack.Push(number);
                }
                else if (commands[0] == "2" && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (commands[0] == "3" && stack.Count > 0)
                {
                    int maxNumber = stack.Max();
                    Console.WriteLine(maxNumber);
                }
                else if (commands[0] == "4" && stack.Count > 0)
                {
                    int minNumber = stack.Min();
                    Console.WriteLine(minNumber);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}