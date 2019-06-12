using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Knights_of_honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string> appends = x => $"Sir {x}";

            Action<List<string>> result = x =>
            Console.WriteLine(string.Join(Environment.NewLine,x.Select(appends)));

            result(names);

        }
    }
}
