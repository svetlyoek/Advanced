using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int index = 0;

            Console.WriteLine(Sum(numbers, index));
        }

        static int Sum(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + Sum(numbers, index + 1);

        }
    }
}
