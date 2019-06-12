using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Queue<string> names = new Queue<string>();
            while ((input = Console.ReadLine()) != "End")
            {
                names.Enqueue(input);
                if (input == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.Write(names.Dequeue());
                    }
                    names.Clear();
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");

        }
    }
}