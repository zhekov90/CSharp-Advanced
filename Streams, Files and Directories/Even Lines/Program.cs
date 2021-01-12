using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            string outputName = "output.txt";

            using (StreamReader streamReader = new StreamReader(fileName))
            {
                using (StreamWriter streamWriter = new StreamWriter(outputName))
                {
                    string line = streamReader.ReadLine();
                    int counter = 0;



                    while (line != null)
                    {
                        if (counter++ % 2 == 0)
                        {
                            var lineArr = line
                            .Split().Reverse().ToArray();

                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < lineArr.Length; i++)
                            {
                                sb.Append(lineArr[i] + " ");
                            }
                            sb = sb.Replace("-", "@");
                            sb = sb.Replace(",", "@");
                            sb = sb.Replace(".", "@");
                            sb = sb.Replace("!", "@");
                            sb = sb.Replace("?", "@");

                            streamWriter.WriteLine(string.Join(" ", sb));
                        }

                        line = streamReader.ReadLine();
                    }
                }

            }

        }
    }
}
