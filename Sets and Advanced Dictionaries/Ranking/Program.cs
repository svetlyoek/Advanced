using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLines = string.Empty;
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();

            while((firstLines=Console.ReadLine())!= "end of contests")
            {
                string[] tokens = firstLines.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string contest = tokens[0];
                string password = tokens[1];

                contestAndPassword.Add(contest, password);
            }

            string secondLines = string.Empty;

            while((secondLines=Console.ReadLine())!= "end of submissions")
            {
                string[] tokens = secondLines.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string contest = tokens[0];
                string password = tokens[1];
                string user = tokens[2];
                int points =int.Parse( tokens[3]);

                if(contestAndPassword.ContainsKey(contest)&&contestAndPassword.ContainsValue(password))
                {
                    if (!ranking.ContainsKey(user))
                    {
                        ranking.Add(user, new Dictionary<string, int>());

                        if (!ranking[user].ContainsKey(contest))
                        {
                            ranking[user][contest] = points;
                        }

                    }
                    else if (ranking.ContainsKey(user))
                    {
                        if (!ranking[user].ContainsKey(contest))
                        {
                            ranking[user][contest] = points;
                        }
                        else if(ranking[user].ContainsKey(contest))
                        {
                            if (ranking[user][contest] < points)
                            {
                                ranking[user][contest] = points;
                            }
                        }
                     

                    }

                    }
                  
                }

            Dictionary<string, int> userTotalPoints = new Dictionary<string, int>();

            foreach(var kvp in ranking)
            {
                userTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            string bestName = userTotalPoints.Keys.Max();

            int totalPoints = userTotalPoints.Values.Max();

            foreach(var kvp in userTotalPoints)
            {
                if(kvp.Value==totalPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {totalPoints} points.");
                }
            }


            Console.WriteLine($"Ranking:");

            foreach(var name in ranking.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{name.Key}");

                foreach(var contestAndPoints in name.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contestAndPoints.Key} -> {contestAndPoints.Value}");
                }
            }
        }
    }
}
