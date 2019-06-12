using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothesAndCounts = new Dictionary<string, Dictionary<string, int>>();


            for (int i = 0; i < counter; i++)
            {
                string[] lines = Console.ReadLine().Split(" -> ").ToArray();

                string color = lines[0];
                List<string> clothes = lines[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!clothesAndCounts.ContainsKey(color))
                {
                    clothesAndCounts.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Count; j++)
                {

                    if (!clothesAndCounts[color].ContainsKey(clothes[j]))
                    {
                        clothesAndCounts[color].Add(clothes[j], 1);
                    }
                    else
                    {
                        clothesAndCounts[color][clothes[j]]++;
                    }

                }
            }


            string[] search = Console.ReadLine().Split().ToArray();
            string findColor = search[0];
            string findClothes = search[1];

            foreach (var color in clothesAndCounts)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothes in color.Value)
                {
                    if (clothes.Key == findClothes && color.Key == findColor)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }

                }

            }
        }
    }
}

