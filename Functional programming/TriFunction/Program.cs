using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                 .Split()
                 .ToList();

            Func<string, int, bool> islargerOrEqualFunc = (name,wordLength) =>
                name.Sum(x => x) >= wordLength;

            Func<List<string>, Func<string, int, bool>, string> filterFunc = (name,filter) =>
                  name.FirstOrDefault(x => filter(x, length));

            string result = filterFunc(names, islargerOrEqualFunc);

            Console.WriteLine(result);
        }
    }
}
