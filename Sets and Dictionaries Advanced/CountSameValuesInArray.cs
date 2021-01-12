using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double value = input[i];
                if (!dict.ContainsKey(value))
                {
                    dict[value] = 0;
                }
                dict[value]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
