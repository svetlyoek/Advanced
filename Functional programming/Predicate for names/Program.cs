using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

          List<string> names = Console.ReadLine()
                .Split()
                .ToList();


            Action<List<string>> result = n => Console.WriteLine(string
                .Join(Environment.NewLine,names
                .Select(x=>x)
                .Where(x=>x.Length<=length)));

            result(names);
        }
    }
}
