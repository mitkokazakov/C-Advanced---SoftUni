using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _5._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\PCB Projects\KPG - 46";

            string[] files = Directory.GetFiles(path);

            Dictionary<string, Dictionary<string, double>> directoryInfo = new Dictionary<string, Dictionary<string, double>>();

            

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string currentFileName = file.Split("\\").Last();
                string currentExtension = fileInfo.Extension;
                double currentKilobytes = fileInfo.Length / 1024.0;

                if (!directoryInfo.ContainsKey(currentExtension))
                {
                    directoryInfo[currentExtension] = new Dictionary<string, double>();
                }

                directoryInfo[currentExtension][currentFileName] = currentKilobytes;

                
                
                //Console.WriteLine($"{currentFileName} --- {currentExtension} --- {currentKilobytes:f2}");
                
            }

            StringBuilder sb = new StringBuilder();

            foreach (var (extension, filesSize) in directoryInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine(extension);

                foreach (var (crntFile, size) in filesSize.OrderBy(x => x.Value))
                {
                    sb.AppendLine($"--{crntFile} - {size:f2}kb");
                }
            }

            File.WriteAllText("../../../report.txt",sb.ToString());
            
        }
    }
}
