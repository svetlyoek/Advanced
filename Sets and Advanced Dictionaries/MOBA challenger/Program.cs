using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string lines = string.Empty;
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();


            while ((lines = Console.ReadLine()) != "Season end")
            {
                if (lines.Contains("->"))
                {
                    string[] tokens = lines.Split(" -> ").ToArray();

                    string player = tokens[0];
                    string position = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!ranking.ContainsKey(player))
                    {
                        ranking.Add(player, new Dictionary<string, int>());

                    }


                    if (!ranking[player].ContainsKey(position))
                    {
                        ranking[player][position] = points;
                    }
                    else
                    {
                        if (ranking[player][position] < points)
                        {
                            ranking[player][position] = points;
                        }
                    }

                }

                else if (lines.Contains("vs"))
                {
                    string[] tokens = lines.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[2];

                    if (ranking.ContainsKey(firstPlayer) && ranking.ContainsKey(secondPlayer))
                    {
                        bool demoted = false;

                        foreach (var first in ranking[firstPlayer])
                        {
                            foreach (var second in ranking[secondPlayer])
                            {
                                if (first.Key == second.Key)
                                {
                                    if (first.Value > second.Value)
                                    {
                                        ranking.Remove(secondPlayer);
                                        demoted = true;
                                        break;
                                    }
                                    else if (second.Value > first.Value)
                                    {
                                        ranking.Remove(firstPlayer);
                                        demoted = true;
                                        break;
                                    }
                                }
                            }


                            if (demoted)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            foreach (var kvp in ranking.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");

                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
    }

}

        
    

