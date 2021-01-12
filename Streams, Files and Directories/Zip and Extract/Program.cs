using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract
{
    class Program
    {
        static void Main(string[] args)
        {

            //string filePath = "copyMe.png";

            //ZipFile.CreateFromDirectory("./", "../../../myZip.zip");


            var zipPath = @"..\..\..\myzip.zip";
            var file = "copyMe.png";

            using (var archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
           
            string extractPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

    }
}
