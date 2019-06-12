using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_some_values_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var dict = new Dictionary<double, int>();
            for(int i=0;i<numbers.Length;i++)
            {
                double currentNumber = numbers[i];

                if(!dict.ContainsKey(currentNumber))
                {
                    dict.Add(currentNumber, 0);
                }

                dict[currentNumber]++;
            }
           foreach(var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
