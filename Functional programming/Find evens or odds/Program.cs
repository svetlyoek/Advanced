using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_evens_or_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            string command = Console.ReadLine();

            int lowerBound = numbers[0];
            int upperBound = numbers[1];

            List<int> listNumbers = new List<int>();

            Predicate<int> filterNumbers = x => command == "even" ? x % 2 == 0 : x% 2 != 0;

            for(int i=lowerBound;i<=upperBound;i++)
            {
                listNumbers.Add(i);
            }

            Action<List<int>> result = x => Console.WriteLine(string.Join(" ",listNumbers.Where(y=>filterNumbers(y))));

            result(listNumbers);
        }
    }
}
