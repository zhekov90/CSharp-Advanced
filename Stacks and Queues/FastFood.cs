using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQty = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            if (foodQty>=0 && foodQty<=1000)
            {
                for (int i = 0; i < orders.Length; i++)
                {
                    if (foodQty < orders[i])
                    {
                        Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                        return;
                    }
                    else
                    {
                        queue.Dequeue();
                        foodQty -= orders[i];
                    }
                }
                Console.WriteLine("Orders complete");
            }
        }
    }
}
