using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Startup
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var person = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = line[0];

                int age = int.Parse(line[1]);

                person.Add(new Person(name, age));

            }


            foreach (var pers in person.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{pers.Name} - {pers.Age}");
            }

        }
    }

}
