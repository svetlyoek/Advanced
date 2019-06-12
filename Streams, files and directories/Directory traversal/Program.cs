using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Directory_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path, "*.*");

            Dictionary<string, List<FileInfo>> extensionInfo = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!extensionInfo.ContainsKey(fileInfo.Extension))
                {
                    extensionInfo.Add(fileInfo.Extension, new List<FileInfo>());
                }

                extensionInfo[fileInfo.Extension].Add(fileInfo);

            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Report.txt";

            using (var writer = new StreamWriter(desktopPath))
            {
                foreach (var kvp in extensionInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine($"{kvp.Key}");

                    foreach (var item in kvp.Value.OrderBy(x => x.Length))
                    {
                        double size = item.Length / 1024;

                        writer.WriteLine($"--{item.Name} - {size:f3}kb");

                    }
                }
            }

        }
    }
}
