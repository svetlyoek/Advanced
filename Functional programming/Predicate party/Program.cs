using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string commands = string.Empty;
            List<string> newGuests = new List<string>();

            while ((commands = Console.ReadLine()) != "Party!")
            {
                string[] tokens = commands
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                string commandCriteria = tokens[1];
                string criteria = tokens[2];
                Func<string, string, bool> predicate;

                predicate = GetCriterias(commandCriteria);

                if (command == "Remove")
                {

                    guests = guests.Where(x => !predicate(x, criteria)).ToList();

                }

                else if (command == "Double")
                {

                    newGuests = guests.Where(x => predicate(x, criteria)).ToList();

                    foreach (var guest in newGuests)
                    {
                        int index = guests.IndexOf(guest);

                        guests.Insert(index + 1, guest);
                    }

                }

            }

            Console.WriteLine(guests.Any() ? $"{string.Join(", ", guests)} are going to the party!"
                : $"Nobody is going to the party!");
        }

        private static Func<string, string, bool> GetCriterias(string commandCriteria)
        {
            if (commandCriteria == "StartsWith")
            {
                return (x, y) => x.StartsWith(y);
            }

            else if (commandCriteria == "EndsWith")
            {
                return (x, y) => x.EndsWith(y);
            }

            else if (commandCriteria == "Length")
            {
                return (x, y) => x.Length == int.Parse(y);
            }

            return null;
        }
    }
}
