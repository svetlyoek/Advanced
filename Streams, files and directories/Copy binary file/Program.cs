using System;
using System.IO;

namespace Copy_binary_file
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new FileStream(@"../../../copyMe.png", FileMode.Open))
            {

                using (var writer = new FileStream(@"../../../Input.png", FileMode.Create))
                {

                    while (true)
                    {
                        byte[] buffer = new byte[4096];

                        var fileSize = reader.Read(buffer, 0, buffer.Length);

                        if(fileSize==0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, fileSize);
                    }
                }
            }

        }
    }
}


