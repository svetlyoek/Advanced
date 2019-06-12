using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            var person = new Person(name,age);

            Console.WriteLine($"{person.Name} - {person.Age}");

        }
    }
}
