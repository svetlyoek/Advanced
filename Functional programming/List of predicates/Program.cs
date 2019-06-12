using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
          
            Console.WriteLine(string.Join(" ", GetNumbers(endRange, dividers)));
        }

        private static List<int> GetNumbers(int endRange, int[] dividers)
        {
            List<int> numbers = new List<int>();

            bool isValid = false;

            for (int i = 1; i <= endRange; i++)
            {
                for (int j = 0; j < dividers.Length; j++)
                {
                    Predicate<int> isDivisible = n => i % n == 0;

                    if(isDivisible(dividers[j]))
                    {
                        isValid = true;
                       
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }

                }

                if(isValid)
                {
                    numbers.Add(i);
                }

            }

            return numbers;
           
        }
    }
}
