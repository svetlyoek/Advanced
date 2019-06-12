using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_reservation_filter_module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            List<string> filters = new List<string>();


            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Print")
            {
                string[] command = commands
                    .Split(';');

                string comm = command[0];
                string filterType = command[1];
                string filterParam = command[2];

                if (comm == "Add filter")
                {

                    filters.Add($"{filterType};{filterParam}");
                }

                else if (comm == "Remove filter")
                {
                    filters.Remove($"{filterType};{filterParam}");

                }
            }

            Func<string, string, bool> startsWithFunc = (name, param) => name.StartsWith(param);

            Func<string, string, bool> endsWithFunc = (name, param) => name.EndsWith(param);

            Func<string, int, bool> lengthFunc = (name, length) => name.Length == length;

            Func<string, string, bool> containsFunc = (name, param) => name.Contains(param);

            foreach (var filter in filters)
            {
                string[] tokens = filter.Split(';');

                string action = tokens[0];

                string param = tokens[1];

                if (action == "Starts with")
                {
                    names = names.Where(name => !startsWithFunc(name, param)).ToList();
                }

                else if (action == "Ends with")
                {
                    names = names.Where(name => !endsWithFunc(name, param)).ToList();
                }
                else if (action == "Length")
                {

                    names = names.Where(name => !lengthFunc(name, int.Parse(param))).ToList();

                }

                else if (action == "Contains")
                {
                    names = names.Where(name => !containsFunc(name, param)).ToList();
                }
            }

            Console.WriteLine(string.Join(" ", names));

        }
    }
}

