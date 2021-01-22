using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> magicLevel = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (materials.Any() && magicLevel.Any())
            {


                int totalMagic = materials.Peek() * magicLevel.Peek();

                if (totalMagic == 150)
                {
                    if (!dict.ContainsKey("Doll"))
                    {
                        dict.Add("Doll", 0);
                    }
                    dict["Doll"]++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (totalMagic == 250)
                {
                    if (!dict.ContainsKey("Wooden train"))
                    {
                        dict.Add("Wooden train", 0);
                    }
                    dict["Wooden train"]++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (totalMagic == 300)
                {
                    if (!dict.ContainsKey("Teddy bear"))
                    {
                        dict.Add("Teddy bear", 0);
                    }
                    dict["Teddy bear"]++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (totalMagic == 400)
                {
                    if (!dict.ContainsKey("Bicycle"))
                    {
                        dict.Add("Bicycle", 0);
                    }
                    dict["Bicycle"]++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else
                {
                    if (totalMagic < 0)
                    {
                        int sum = materials.Peek() + magicLevel.Peek();
                        materials.Pop();
                        magicLevel.Dequeue();
                        materials.Push(sum);
                        continue;
                    }
                    if (totalMagic == 0)
                    {
                        if (materials.Peek() == 0 && magicLevel.Peek() == 0)
                        {
                            materials.Pop();
                            magicLevel.Dequeue();
                            continue;
                        }
                        else if (materials.Peek() == 0)
                        {
                            materials.Pop();
                            continue;
                        }
                        else if (magicLevel.Peek() == 0)
                        {
                            magicLevel.Dequeue();
                            continue;
                        }

                    }
                    else
                    {
                        magicLevel.Dequeue();
                        int lastMaterial = materials.Pop();
                        materials.Push(lastMaterial + 15);
                    }
                }


            }

            if (dict.ContainsKey("Doll") && dict.ContainsKey("Wooden train") || dict.ContainsKey("Teddy bear") && dict.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }

            if (magicLevel.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");
            }

            dict = dict.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, v => v.Value);

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
