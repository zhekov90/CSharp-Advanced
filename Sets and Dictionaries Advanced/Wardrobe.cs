using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();
                string color = input[0];
                    string clothes = input[1];
                    string[] separatedClothes = clothes.Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    for (int j   = 0; j < separatedClothes.Length; j++)
                    {
                        if (!dict.ContainsKey(color))
                        {
                            dict[color] = new Dictionary<string, int>();
                        dict[color].Add(separatedClothes[j], 0);
                        }
                        else
                        {
                            if (!dict[color].ContainsKey(separatedClothes[j]))
                            {
                                dict[color].Add(separatedClothes[j], 0);
                            }
                        }
                    dict[color][separatedClothes[j]]++;
                }
            }
            string[] input2 = Console.ReadLine().Split().ToArray();

            string colorToCheck = input2[0];
            string clothing = input2[1];
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var cloth in item.Value)
                {
                    if (colorToCheck==item.Key && clothing==cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
