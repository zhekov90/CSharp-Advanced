using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var boxes = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            
            int racks = 1;
            int currentRackCapacity = capacity;
            while (boxes.Count>0)
            {
                int currentClothes = boxes.Peek();
                

                if (currentRackCapacity>=currentClothes)
                {
                    currentRackCapacity -= currentClothes;
                    boxes.Pop();
                }
                else
                {
                    racks++;
                    currentRackCapacity = capacity;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
