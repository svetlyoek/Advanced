using System;
using System.Linq;

namespace Custom_comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();

            int[] oddNumbers = numbers.Where(x => x % 2 != 0).ToArray();

            Func<int, int, int> comparer = (x, y) => x.CompareTo(y);

            Array.Sort(evenNumbers, new Comparison<int>(comparer));

            Array.Sort(oddNumbers, new Comparison<int>(comparer));

            Console.WriteLine($"{string.Join(" ",evenNumbers)} {string.Join(" ",oddNumbers)}");


        }
    }
}
