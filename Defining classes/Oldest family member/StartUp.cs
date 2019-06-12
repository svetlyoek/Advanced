﻿using System;

class Startup
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        var family = new Family();

        for (int i = 0; i < lines; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var person = new Person(line[0], int.Parse(line[1]));

            family.AddMember(person);
        }

        var oldestMember = family.GetOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}
