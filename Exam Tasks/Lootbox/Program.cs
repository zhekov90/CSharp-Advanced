using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var first = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            var second = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumClaimedItems = 0;
            int sum = 0;

            Queue<int> firstLootBox = new Queue<int>(first);
            Stack<int> secondLootBox = new Stack<int>(second);

            while (firstLootBox.Any() && secondLootBox.Any())
            {
                sum += firstLootBox.Peek() + secondLootBox.Peek();

                if (sum%2==0)
                {
                    sumClaimedItems += sum;
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    int temp = secondLootBox.Pop();
                    firstLootBox.Enqueue(temp);
                }

                sum = 0;
            }

            if (firstLootBox.Count==0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (sumClaimedItems>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sumClaimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sumClaimedItems}");
            }
        }
    }
}
