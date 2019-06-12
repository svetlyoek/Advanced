using System;
using System.IO;

namespace Line_numbers_II
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"..\..\..\text.txt"))
            {
                using (var writer = new StreamWriter(@"..\..\..\Input.txt"))
                {
                    int counter = 1;

                    var line = reader.ReadLine();
                    int lettersCount = 0;
                    int othersCount = 0;

                    while(line!=null)
                    {
                        for(int i=0;i<line.Length;i++)
                        {
                            if(Char.IsLetter(line[i]))
                            {
                                lettersCount++;
                            }

                            else
                            {
                                if(!Char.IsWhiteSpace(line[i]))
                                {
                                    othersCount++;
                                }
                               
                            }
                        }

                        writer.WriteLine($"Line {counter}:{line}({lettersCount})({othersCount})");

                        line = reader.ReadLine();

                        counter++;

                        lettersCount = 0;
                        othersCount = 0;

                    }
                }
            }
        }
    }
}
