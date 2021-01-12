using System;
using System.IO;
using System.Linq;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "text.txt";
            string outputName = "output.txt";
             
            
            using StreamReader streamReader = new StreamReader(fileName);


                using StreamWriter streamWriter = new StreamWriter(outputName);
                
                    var line = streamReader.ReadLine();
                    int counter = 0;
                    int counterLetters = 0;
                    int counterMarks = 0;
                    while (line != null)
                    {

                counter++;
                            var lineArr = line.ToArray();
                for (int i = 0; i < lineArr.Length; i++)
                {
                    var currChar = lineArr[i];
                   
                        
                        if (char.IsLetter(currChar))
                        {
                            counterLetters++;
                        }
                        else if (currChar == '-' || currChar == ',' || currChar == '.' || currChar == '!' || currChar == '?' || currChar == '\'')
                        {
                            counterMarks++;
                        }
                    
                    
                }
                            string result = string.Join("", lineArr);
                streamWriter.Write($"Line {counter}: ");
                            streamWriter.WriteLine($"{result} ({counterLetters})({counterMarks})");

                counterLetters = 0;
                counterMarks = 0;
                        line = streamReader.ReadLine();
                    }
                

            
        }
    }
}
