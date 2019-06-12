using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_uppercase_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpper = x => x[0] == (x.ToUpper()[0]);

            Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Where(isUpper)
                  .ToList()
                  .ForEach(Console.WriteLine);


        }
    }
}
