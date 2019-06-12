using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = Console.ReadLine().Split().ToArray();
            Stack<string> result = new Stack<string>(text.Reverse());
            int sum = int.Parse(result.Pop());
            while (result.Any())
            {
                var nextSymbol = result.Pop();
                if (nextSymbol == "+")
                {
                    sum += int.Parse(result.Pop());
                }
                else if (nextSymbol == "-")
                {
                    sum -= int.Parse(result.Pop());
                }
            }
            Console.WriteLine(sum);
        }
    }
}