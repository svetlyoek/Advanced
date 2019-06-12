using System;
using System.Collections.Generic;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vatPrices = x => x * 1.20;

           var prices= Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Select(vatPrices)
                 .ToArray();

            foreach(var num in prices)
            {
                Console.WriteLine($"{num:f2}");
            }
                 



        }
    }
}
