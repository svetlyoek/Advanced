using System;
using System.IO;

namespace Merge_files
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var firstReader = new StreamReader(@"..\..\..\FileOne.txt"))
            {
                string firstLine = firstReader.ReadLine();

                using (var secondReader = new StreamReader(@"..\..\..\FileTwo.txt"))
                {
                    string secondLine = secondReader.ReadLine();

                    using (var writer = new StreamWriter(@"..\..\..\Output.txt"))
                    {
                        while (firstLine != null)
                        {

                            writer.WriteLine(firstLine);
                            writer.WriteLine(secondLine);

                            secondLine = secondReader.ReadLine();

                            firstLine = firstReader.ReadLine();
                        }
                    }

                }

            }

        }
    }
}

