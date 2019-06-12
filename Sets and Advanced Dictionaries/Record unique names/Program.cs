using System;
using System.Collections.Generic;

namespace Record_unique_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesCounter = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();

            for(int i=0;i<namesCounter;i++)
            {
                string currentName = Console.ReadLine();

                set.Add(currentName);
            }
          
            
            foreach(var name in set)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
