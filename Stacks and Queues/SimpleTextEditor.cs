using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            var builder = new StringBuilder();
            var stack = new Stack<string>();
            stack.Push(builder.ToString());


            for (int i = 0; i < number; i++)
            {
                string[] command = Console.ReadLine().Split();
                int commandNumber = int.Parse(command[0]);

                if (commandNumber == 1)
                {
                    builder.Append(command[1]);
                    stack.Push(builder.ToString());
                }
                else if (commandNumber == 2)
                {
                    int count = int.Parse(command[1]);
                    builder.Remove(builder.Length - count, count);
                    stack.Push(builder.ToString());

                }
                else if (commandNumber == 3)
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(builder[index-1]);
                }
                else if (commandNumber == 4)
                {
                    stack.Pop();
                    builder = new StringBuilder();
                    builder.Append(stack.Peek());
                }
            }

        }
    }
}
