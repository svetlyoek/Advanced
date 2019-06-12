using System;
using System.IO;

namespace Odd_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"..\..\..\Input.txt"))
            {
                int counter = 0;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter(@"..\..\..\Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
