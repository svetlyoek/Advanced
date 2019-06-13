using System;
using System.Collections.Generic;

namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<double>();

            int elementCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < elementCounter; i++)
            {
                double number = double.Parse(Console.ReadLine());

                box.Add(number);
            }

            double compareItem = double.Parse(Console.ReadLine());

            int count = CompareElements(box.Data, compareItem);

            Console.WriteLine(count);
        }

        public static int CompareElements<T>(List<T> data, T item)
         where T : IComparable
        {
            int counter = 0;

            foreach (var element in data)
            {
                if (element.CompareTo(item) > 0)
                {
                    counter++;
                }
            }

            return counter;

        }
    }

}
