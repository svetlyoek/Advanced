using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setLengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int firstLength = setLengths[0];
            int secondLength = setLengths[1];
            int counter = firstLength + secondLength;

            for(int i=0;i<counter;i++)
            {
                int numbers = int.Parse(Console.ReadLine());

               if(i<firstLength)
                {
                    firstSet.Add(numbers);
                }
               else if(i>=firstLength)
                {
                    secondSet.Add(numbers);
                }
            }

            foreach(var number in firstSet)
            {
                if(secondSet.Contains(number))
                {
                    Console.Write(number+" ");
                }
            }
        }
    }
}
