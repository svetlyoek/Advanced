using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> text = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                text.Push(input[i].ToString());
            }
            while (text.Any())
            {
                Console.Write($"{text.Pop()}");
            }
        }
    }
}