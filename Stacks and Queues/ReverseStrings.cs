using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Stack<char> myStack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                myStack.Push(input[i]);
            }
            while (myStack.Any())
            {
                Console.Write(myStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
