using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string commands = string.Empty;
            ListyIterator<string> listyIterator = null;

            while ((commands = Console.ReadLine()) != "END")
            {
                try
                {
                    if (commands.Contains("Create"))
                    {
                        List<string> command = commands.Split().Skip(1).ToList();

                        listyIterator = new ListyIterator<string>(command);
                    }
                    else if (commands == "Print")
                    {
                        listyIterator.Print();
                    }
                    else if (commands == "HasNext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (commands == "Move")
                    {
                        Console.WriteLine(listyIterator.Move());
                    }
                    else if (commands == "PrintAll")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write(item + " ");

                        }
                        Console.WriteLine();
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid Operation!");
                }
            }
        }
    }
}
