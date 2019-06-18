using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        public static void Main()
        {
            var stack = new Stack<int>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input.Contains("Push"))
                {
                    int[] numbers = input
                        .Split(new string[] { "Push", ",", " " }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in numbers)
                    {
                        stack.Push(item);
                    }

                }
                else if (input.Contains("Pop"))
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("No elements");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}



