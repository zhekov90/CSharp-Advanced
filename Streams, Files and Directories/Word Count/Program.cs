using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathWords = "words.txt";
            string[] words = File.ReadAllLines(pathWords);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string pathText = "text.txt";
            string[] lines = File.ReadAllLines(pathText);


            foreach (var word in words)
            {
                dict.Add(word.ToLower(), 0);
            }
            foreach (var line in lines)
            {
                string[] currLine = line.ToLower().Split(' ', ',', '-', '?', '!', '.', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var word in currLine)
                {
                    if (dict.ContainsKey(word))
                    {
                        dict[word]++;
                    }
                    
                }
            }
            StringBuilder sb1 = new StringBuilder();
            foreach ((string word, int count) in dict)
            {
                sb1.AppendLine($"{word} - {count}");
            }
            File.WriteAllText("actualResult.txt", sb1.ToString());
            dict = dict.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, y => y.Value);

            StringBuilder sb = new StringBuilder();
            
            foreach ((string word, int count) in dict)
            {
                sb.AppendLine($"{word} - {count}");
            }
            File.WriteAllText("expectedResult.txt", sb.ToString());

        }
    }
}
