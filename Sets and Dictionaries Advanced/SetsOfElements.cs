using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> first = new List<int>();
            List<int> second = new List<int>();

            for (int i = 0; i < numbers[0]; i++)
            {
                int line = int.Parse(Console.ReadLine());
                first.Add(line);
            }
            for (int j = 0; j < numbers[1]; j++)
            {
                int line = int.Parse(Console.ReadLine());
                second.Add(line);
            }
           
            Console.WriteLine(string.Join(" ", first.Intersect(second)));
        }
    }
}
