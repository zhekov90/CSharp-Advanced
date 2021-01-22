using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool fulfillPouch = false;
            Queue<int> bombEffect = new Queue<int>(input1);
            Stack<int> bombCasing = new Stack<int>(input2);
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while ((bombEffect.Count>0 && bombCasing.Count>0) && !fulfillPouch)
            {
                if (!dict.ContainsKey("Datura Bombs"))
                {
                    dict.Add("Datura Bombs", 0);
                }
                if (!dict.ContainsKey("Cherry Bombs"))
                {
                    dict.Add("Cherry Bombs", 0);
                }
                if (!dict.ContainsKey("Smoke Decoy Bombs"))
                {
                    dict.Add("Smoke Decoy Bombs", 0);
                }
                int sum = bombEffect.Peek() + bombCasing.Peek();
                if (sum == 40)
                {
                    dict["Datura Bombs"]++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 60)
                {
                    dict["Cherry Bombs"]++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else if (sum == 120)
                {
                    dict["Smoke Decoy Bombs"]++;
                    bombEffect.Dequeue();
                    bombCasing.Pop();
                }
                else
                {
                    int temp = bombCasing.Peek();
                    bombCasing.Pop();
                    bombCasing.Push(temp - 5);
                }
                if (dict.ContainsKey("Datura Bombs") && dict.ContainsKey("Smoke Decoy Bombs") && dict.ContainsKey("Cherry Bombs"))
                {
                    if (dict["Datura Bombs"] >= 3 && dict["Cherry Bombs"] >= 3 && dict["Smoke Decoy Bombs"] >= 3)
                    {
                        fulfillPouch = true;
                    }

                }
            }
            if (fulfillPouch)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffect.Any())
            {
                Console.WriteLine($"Bomb Effects: { string.Join(", ", bombEffect)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach (var bomb in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
