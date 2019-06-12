using System;
using System.Collections.Generic;
using System.Linq;
namespace Count_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            Dictionary<char, int> charsAndCounts = new Dictionary<char, int>();

            for(int i=0;i<symbols.Length;i++)
            {
                var currentChar = symbols[i];

                if(!charsAndCounts.ContainsKey(currentChar))
                {
                    charsAndCounts.Add(currentChar,1);
                }

                else
                {
                    charsAndCounts[currentChar]++;
                }
            }

            foreach(var symbol in charsAndCounts.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }

        }
    }
}
