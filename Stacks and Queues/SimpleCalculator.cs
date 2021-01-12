using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] values = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> myStack = new Stack<string>(values.Reverse());

            while (myStack.Count>1)
            {
                int first = int.Parse(myStack.Pop());
                string separator = myStack.Pop();
                int second = int.Parse(myStack.Pop());

                if (separator=="+")
                {
                    myStack.Push((first + second).ToString());
                }
                else if (separator=="-")
                {
                    myStack.Push((first - second).ToString());
                }
            }
            Console.WriteLine(myStack.Pop());
        }
    }
}
