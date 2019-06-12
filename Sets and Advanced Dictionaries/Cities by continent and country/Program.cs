using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_by_continent_and_country
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCounter = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for(int i=0;i<linesCounter;i++)
            {
                string[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string continent = line[0];
                string country = line[1];
                string city = line[2];

                if(!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                }

                if(!dict[continent].ContainsKey(country))
                {
                    dict[continent][country]=new List<string>();
                }

                dict[continent][country].Add(city);
            }

            foreach(var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
