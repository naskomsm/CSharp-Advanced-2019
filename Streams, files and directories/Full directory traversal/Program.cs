using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Full_directory_traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            Dictionary<string, List<FileInfo>> extensionFileInfo = new Dictionary<string, List<FileInfo>>(); // the kvp.key is fileType ( .rar ; .exe etc... )

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);

                if (!extensionFileInfo.ContainsKey(info.Extension))
                {
                    extensionFileInfo[info.Extension] = new List<FileInfo>();
                    extensionFileInfo[info.Extension].Add(info);

                }
            }

            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Report.txt"; // ty stackoverflow
            
            using (StreamWriter writer = new StreamWriter(pathToDesktop))
            {
                foreach (var kvp in extensionFileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    string ext = kvp.Key;
                    var info = kvp.Value;

                    writer.WriteLine(ext);

                    foreach (var fileInfo in info.OrderByDescending(x=>x.Length))
                    {
                        string name = fileInfo.Name;
                        double size = fileInfo.Length / 1024;


                        writer.WriteLine($"--{name} - {size:f3}kb");
                    }
                }
            } // write everything to the file on the given path.

        }
    }
}
