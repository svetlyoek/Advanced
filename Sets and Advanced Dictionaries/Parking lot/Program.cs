using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> carNumbers = new HashSet<string>();

            while((input=Console.ReadLine())!="END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string direction = tokens[0];
                string carNumber = tokens[1];

                if(direction=="IN")
                {
                    carNumbers.Add(carNumber);
                }

                else if(direction=="OUT")
                {
                    carNumbers.Remove(carNumber);
                }
            }

            if(carNumbers.Count>0)
            {
                foreach(var car in carNumbers)
                {
                    Console.WriteLine($"{car}");
                }
             
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
