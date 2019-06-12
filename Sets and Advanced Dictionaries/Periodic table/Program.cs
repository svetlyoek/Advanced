using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for(int i=0;i<counter;i++)
            {
                string[] elements = Console.ReadLine().Split().ToArray();

               foreach(var item in elements)
                {
                    set.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ",set.OrderBy(x=>x)));
        }
    }
}
