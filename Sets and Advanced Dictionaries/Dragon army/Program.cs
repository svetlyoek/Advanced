using System;
using System.Collections.Generic;
using System.Linq;

namespace Dragon_army
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string,int[]>> dragons = new Dictionary<string, SortedDictionary<string,int[]>>();
            int initialHealth = 250;
            int initialDamage = 45;
            int initialArmor = 10;

            for (int i = 0; i < counter; i++)
            {
                string[] lines = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string type = lines[0];
                string name = lines[1];
                string damage = lines[2];
                string health = lines[3];
                string armor = lines[4];

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string,int[]>());
                }
                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type].Add(name, new int[3]);
                }
                if (dragons.ContainsKey(type) && dragons[type].ContainsKey(name))
                {
                    if (damage != "null")
                    {
                        int number = int.Parse(damage);
                        dragons[type][name][0]=number;
                    }
                    else if (damage == "null")
                    {

                        dragons[type][name][0]=initialDamage;
                    }
                    if (health != "null")
                    {
                        int number = int.Parse(health);
                        dragons[type][name][1]=number;
                    }
                    else if (health == "null")
                    {

                        dragons[type][name][1]=initialHealth;
                    }
                    if (armor != "null")
                    {
                        int number = int.Parse(armor);
                        dragons[type][name][2]=number;
                    }

                    else if (armor == "null")
                    {

                        dragons[type][name][2]=initialArmor;
                    }

                }
            }
            double averageDamage = 0.0;
            double averageHealth = 0.0;
            double averageArmor = 0.0;


            foreach (var type in dragons)
            {
                averageDamage = 1.00 * type.Value.Values.Select(x => x[0]).Sum() / dragons[type.Key].Count();
                averageHealth = 1.00 * type.Value.Values.Select(x => x[1]).Sum() / dragons[type.Key].Count();
                averageArmor = 1.00 * type.Value.Values.Select(x => x[2]).Sum() / dragons[type.Key].Count();

                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}