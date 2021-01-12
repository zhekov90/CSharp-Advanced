using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            string searchExtension = ".";
            string path = "./";

            string[] fileNames = Directory.GetFiles(path, $"*{searchExtension}*");

            foreach (var filePath in fileNames)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string extension = fileInfo.Extension;
                string shortFileName = fileInfo.Name;
                double length = fileInfo.Length / 1024.0;

                if (!dict.ContainsKey(extension))
                {
                    dict.Add(extension, new Dictionary<string, double>());
                }
                dict[extension].Add(shortFileName, length);

            }


            StringBuilder sb = new StringBuilder();
            foreach (var extension in dict.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                sb.AppendLine(extension.Key);
                foreach (var file in extension.Value.OrderBy(x=>x.Value))
                {
                    sb.AppendLine($"--{file.Key} - {file.Value:f3}kb");
                }
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string resultPath = Path.Combine(desktopPath, "report.txt");
            File.WriteAllText(resultPath, sb.ToString());

           
        }
    }
}
