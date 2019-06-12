using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] lines = command.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string shop = lines[0];
                string product = lines[1];
                double price = double.Parse(lines[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict.Add(shop, new Dictionary<string, double>());
                }
             

                dict[shop][product] = price;

            }

            foreach (var kvp in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}->");

                foreach(var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }

            }

        }
    }
}
