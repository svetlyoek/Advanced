using System;
using System.Linq;

namespace Custom_min_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Console.WriteLine(Print(numbers));
        }

        private static int Print(int[] numbers)
        {
            int minValue = int.MaxValue;

            foreach(var num in numbers)
            {
                if(num<minValue)
                {
                    minValue = num;
                }
            }

            return minValue;
        }
    }
}
