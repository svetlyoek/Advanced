using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .Where(x => x % 2 == 0)
                  .OrderBy(x => x)
                  .ToArray();

          
                Console.WriteLine(string.Join(", ",numbers));
            
                
        }
    }
}
