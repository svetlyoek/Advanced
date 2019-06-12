using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_student_grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCounter = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < gradesCounter; i++)
            {
                string[] namesAndGrades = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = namesAndGrades[0];
                double currentGrade = double.Parse(namesAndGrades[1]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new List<double>());
                }

                dict[name].Add(currentGrade);
            }

            foreach (var kvp in dict)
            {
                Console.Write($"{kvp.Key} -> ");

                foreach (var grade in kvp.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {kvp.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}

