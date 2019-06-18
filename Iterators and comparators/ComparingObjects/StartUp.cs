using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string lines = string.Empty;
            var list = new List<Person>();

            while ((lines = Console.ReadLine()) != "END")
            {
                string[] tokens = lines.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                list.Add(new Person(name, age, town));
            }

            int equalCount = 0;

            int notEqualCount = 0;

            int index = int.Parse(Console.ReadLine());

            var personToCompare = list[index - 1];

            foreach (var person in list)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    notEqualCount++;
                }
            }

            if (equalCount < 2)
            {
                Console.WriteLine($"No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {notEqualCount} {list.Count}");
            }
        }
    }
}
