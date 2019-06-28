using System;
using System.Linq;

namespace BinarySearch
{
    public class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int key = int.Parse(Console.ReadLine());

            Console.WriteLine(IndexOf(numbers, key));
        }

        private static int IndexOf(int[] numbers, int key)
        {
            int start = 0;
            int end = numbers.Length - 1;

            while (start <= end)
            {
                int middle = end + start / 2;

                if (key < numbers[middle])
                {
                    end = middle - 1;
                }
                else if (key > numbers[middle])
                {
                    start = middle + 1;
                }
                else
                {
                    return middle;
                }

            }

            return -1;
        }
    }
}
