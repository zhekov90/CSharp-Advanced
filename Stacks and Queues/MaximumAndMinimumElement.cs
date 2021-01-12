using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            if (1<=number && number<= 105)
            {
                for (int i = 0; i < number; i++)
                {
                    int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    if (command[0]>=1 && command[0]<=4)
                    {
                        if (command[0] == 1 && command[1] >= 1 && command[1] <= 109)
                        {
                            stack.Push(command[1]);
                        }
                        else if (command[0] == 2 && stack.Any())
                        {
                            stack.Pop();
                        }
                        else if (command[0] == 3 && stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        else if (command[0] == 4 && stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                    }
                   
                }
            }
            
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
