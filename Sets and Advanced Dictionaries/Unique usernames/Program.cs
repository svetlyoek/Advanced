using System;
using System.Collections.Generic;

namespace Unique_usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCounter = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for(int i=0;i<namesCounter;i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
