using System;
using System.IO;
using System.Linq;

namespace Even_lines
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
         
            string symbols = "-,.!?";

            using (var reader = new StreamReader(@"..\..\..\text.txt"))
            {
             
                using (var writer = new StreamWriter(@"..\..\..\Input.txt"))
                {
                  

                    while (true)
                    {
                        var line = reader.ReadLine();

                        if(line==null)
                        {
                            break;
                        }

                        if (counter%2==0)
                        {
                            string newText = string.Empty;

                            foreach (var character in line)
                            {
                                if(symbols.Contains(character))
                                {
                                    newText += '@';
                                }
                                else
                                {
                                    newText += character;
                                }
                            }
                            string[] splitedText = newText.Split();

                            Array.Reverse(splitedText);

                            writer.WriteLine(string.Join(" ",splitedText));
                        }

                     
                        counter++;

                       
                    }

                }

            }
        }

    }
}

