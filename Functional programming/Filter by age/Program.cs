using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_age
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            var people = new List<Person>();

            for (int i = 0; i < counter; i++)
            {
                var lines = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                var person = new Person
                {
                    Name = lines[0],
                    Age = int.Parse(lines[1])
                };

                people.Add(person);

            }

            string command = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filteredPredicate;

            if (command == "older")
            {
                filteredPredicate = p => p.Age >= age;
            }

            else 
            {
                filteredPredicate = p => p.Age < age;
            }


            string orderInfo = Console.ReadLine();

            Func<Person, string> selectPerson;

            if (orderInfo == "name age")
            {
                selectPerson = p => $"{p.Name} - {p.Age}";
            }

            else if(orderInfo=="age")
            {
                selectPerson = p => $"{p.Age}";
            }

            else 
            {
                selectPerson = p => $"{p.Name}";
            }

            people
                 .Where(filteredPredicate)
                 .Select(selectPerson)
                 .ToList()
                 .ForEach(Console.WriteLine);

        }
    }
}
