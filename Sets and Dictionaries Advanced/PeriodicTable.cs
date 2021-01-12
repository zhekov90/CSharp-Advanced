using System;
using System.Collections.Generic;
using System.Linq;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputLines = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int j = 0; j < inputLines.Length; j++)
                {
                    elements.Add(inputLines[j]);
                }

            }
            foreach (var el in elements)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();
        }
    }
}
