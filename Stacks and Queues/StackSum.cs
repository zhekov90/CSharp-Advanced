using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> myStack = new Stack<int>(input);

            
            while (true)
            {
                string[] command = Console.ReadLine().ToLower().Split();
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0]=="add")
                {
                    myStack.Push(int.Parse(command[1]));
                    myStack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    int number = int.Parse(command[1]);
                    if (number>myStack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < number; i++)
                    {
                        myStack.Pop();
                    }
                }

            }
            var sum = myStack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
