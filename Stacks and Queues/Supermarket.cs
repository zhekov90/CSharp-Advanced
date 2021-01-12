using System;
using System.Collections;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name =="End")
                {
                    break;
                }
                
                else if(name =="Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, names));
                    names.Clear();
                }
                else
                {
                    names.Enqueue(name);
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
