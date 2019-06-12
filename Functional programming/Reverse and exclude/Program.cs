using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_exclude
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numToDivision = int.Parse(Console.ReadLine());

            Array.Reverse(numbers);

            Predicate<int[]> result = n => n == n.Where(x => x % numToDivision != 0);

            Action<int[]> print = n => Console.WriteLine(string.Join(" ", numbers.Where(x => x % numToDivision != 0)));
               
            print(numbers);
        }
    }
}
