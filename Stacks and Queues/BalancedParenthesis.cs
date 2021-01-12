using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var openChar = new Stack<char>();
            bool isBalanced = true;

            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    openChar.Push(c);
                }
                else
                {

                    if (!openChar.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    char currOpenChar = openChar.Pop();
                    bool isRoundBalanced = currOpenChar == '(' && c == ')';
                    bool isCurlyBalanced = currOpenChar == '{' && c == '}';
                    bool isSquareBalanced = currOpenChar == '[' && c == ']';
                    if (isRoundBalanced == false && isCurlyBalanced == false && isSquareBalanced == false)
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
