using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            using (var wordReader = new StreamReader(@"..\..\..\words.txt"))
            {
                string[] words = wordReader.ReadLine().Split();

                String pattern = @"[a-zA-Z']+";

                Regex regex = new Regex(pattern);

                using (var textReader = new StreamReader(@"..\..\..\text.txt"))
                {
                    string currentLine = textReader.ReadLine();

                    while (currentLine != null)
                    {
                        foreach (Match match in regex.Matches(currentLine))
                        {
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (match.Value.ToLower() == words[i] && !dict.ContainsKey(words[i]))
                                {
                                    dict.Add(words[i], 1);
                                }
                                else if (match.Value.ToLower() == words[i] && dict.ContainsKey(words[i]))
                                {
                                    dict[words[i]]++;
                                }
                            }
                        }
                        currentLine = textReader.ReadLine();
                    }
                }
            }

            using (var writer = new StreamWriter(@"..\..\..\Output.txt"))
            {
                foreach (var words in dict.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{words.Key} - {words.Value}");

                    writer.WriteLine($"{words.Key} - {words.Value}");
                }
            }


        }
    }
}





