using System;
using System.Collections.Generic;
using System.Linq;

namespace The_v_logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            HashSet<string> vloggers = new HashSet<string>();
            Dictionary<string, HashSet<string>> followers = new Dictionary<string,HashSet< string>>();
            Dictionary<string, HashSet<string>> following = new Dictionary<string,HashSet< string>>();

            while((text=Console.ReadLine())!="Statistics")
            {
                string[] tokens = text.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens.Length==4)
                {
                   
                    string name = tokens[0];
                    vloggers.Add(name);

                    if (!followers.ContainsKey(name)&&!following.ContainsKey(name))
                    {
                       
                        followers.Add(name, new HashSet<string>());
                        following.Add(name, new HashSet<string>());
                    }
                }

                else if(tokens.Length==3)
                {
                   
                    string firstVlogger = tokens[0];
                    string secondVlogger = tokens[2];

                    if(vloggers.Contains(firstVlogger)&&vloggers.Contains(secondVlogger))
                    {
                        if (firstVlogger != secondVlogger)
                        {
                            followers[secondVlogger].Add(firstVlogger);

                            following[firstVlogger].Add(secondVlogger);
                        }
                    }
                  
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var topUser = followers.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => following[x.Key].Count())
                .FirstOrDefault();

            Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers, {following[topUser.Key].Count} following");


            foreach(var names in topUser.Value.OrderBy(x=>x))
            {
                Console.WriteLine($"*  {names}");
            }

            int counter = 2;

            foreach (var user in followers.Where(x => x.Key != topUser.Key)
                .OrderByDescending(x => x.Value.Count)
                 .ThenBy(x => following[x.Key].Count()))
            {
                Console.WriteLine($"{counter}. {user.Key} : {user.Value.Count} followers, {following[user.Key].Count} following");
                counter++;
            }
        }
    }
}
