using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main()
        {
            var box = new Box<int>();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int number = int.Parse(Console.ReadLine());

                box.Add(number);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            box.Swap<int>(firstIndex, secondIndex);
            Console.WriteLine(box.ToString());
        }
    }
    }
