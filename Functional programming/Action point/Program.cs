using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                    .Split()
                    .ToArray();

            Action<string[]> action = n=>Console.WriteLine(string.Join(Environment.NewLine,names));

            action(names);
         

        }

    }
}

