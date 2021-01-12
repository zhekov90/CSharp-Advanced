using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }
            KeyValuePair<int, int> kvp = numbers.First(n => n.Value % 2 == 0);
            Console.WriteLine(kvp.Key);
        }
    } 
}
