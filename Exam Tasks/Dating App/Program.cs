using System;
using System.Collections.Generic;
using System.Linq;

namespace Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputMales = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputFemales = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int matches = 0;

            Stack<int> males = new Stack<int>(inputMales);
            Queue<int> females = new Queue<int>(inputFemales);

            while (males.Count > 0 && females.Count > 0)
            {
                int currMale = males.Peek();
                int currFemale = females.Peek();

                if (males.Peek()%25==0 && males.Peek()!=0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }
                if (females.Peek()%25==0 && females.Peek() != 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }
                if (currMale == currFemale)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currMale - 2);
                }


            }
            Console.WriteLine($"Matches: {matches}");
            if (males.Any())
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine($"Males left: none");
            }
            if (females.Any())
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine($"Females left: none");
            }

        }
    }
}
