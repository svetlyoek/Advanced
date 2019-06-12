using System;
using System.Collections.Generic;

namespace Even_times
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbersAndCounts = new Dictionary<int, int>();

            for(int i=0;i<counter;i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if(!numbersAndCounts.ContainsKey(currentNumber))
                {
                    numbersAndCounts.Add(currentNumber, 1);
                }

                else
                {
                    numbersAndCounts[currentNumber]++;
                   
                }
            }

            foreach(var item in numbersAndCounts)
            {
                if(item.Value%2==0)
                {
                    Console.WriteLine($"{item.Key}");
                }
            }

        }
    }
}
