using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Lake<int> lake = null;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    lake = new Lake<int>(numbers);
                }
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    lake = new Lake<int>(numbers);
                }
            }

            Console.WriteLine(string.Join(", ", lake));

        }

    }
}
