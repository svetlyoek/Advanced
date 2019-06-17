using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main()
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
                    else if (commands.Contains("Print"))
                    {
                        listyIterator.Print();
                    }
                    else if (commands.Contains("HasNext"))
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if (commands.Contains("Move"))
                    {
                        Console.WriteLine(listyIterator.Move());
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
