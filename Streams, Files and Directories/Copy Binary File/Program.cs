using System;
using System.IO;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream readFileStream = new FileStream("copyMe.png", FileMode.Open);

            using FileStream writeFileStream = new FileStream("SoftuniLogo.png", FileMode.Create);

            byte[] buffer = new byte[4096];

            
            while (readFileStream.CanRead)
            // or --> while (!readFIleStream.EndOfStream)
            {

                int counter = readFileStream.Read(buffer, 0, buffer.Length);

                if (counter==0)
                {
                    break;
                }
                
                writeFileStream.Write(buffer);
            }
           


        }
    }
}
