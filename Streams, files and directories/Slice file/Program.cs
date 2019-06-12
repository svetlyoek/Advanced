using System;
using System.Collections.Generic;
using System.IO;

namespace Slice_file
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int parts = int.Parse(Console.ReadLine());

            using (var streamReadFile = new FileStream(@"..\..\..\sliceMe.txt", FileMode.Open))
            {
                var pieceSize = Math.Ceiling((double)streamReadFile.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    long currentPieceSize = 0;

                    var currentFile = $@"..\..\..\Part-{i}.txt";

                    using (var streamCreateFile = new FileStream(currentFile, FileMode.Create))
                    {

                        while (true)
                        {
                            byte[] buffer = new byte[4096];

                            var totalread = streamReadFile.Read(buffer, 0, buffer.Length);

                            if (totalread == 0)
                            {
                                break;
                            }

                            currentPieceSize += totalread;

                            streamCreateFile.Write(buffer, 0, buffer.Length);

                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }


                        }
                    }
                }
            }
        }
    }
}

