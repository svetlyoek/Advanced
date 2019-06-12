using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_extract
{
    class Program
    {
        static void Main(string[] args)
        {
            var zipFile = @"..\..\..\copyMe.zip";

            var file = @"..\..\..\copyMe.png";

            var unzipPath = @"..\..\..\unzipCopyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }

            ZipFile.ExtractToDirectory(zipFile, unzipPath);
        }
    }
}
