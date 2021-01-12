using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int passed = 0;
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="end")
                {
                    break;
                }
                else if (command=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Any())
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            
                            passed++;
                        }
                       
                    }
                    
                }
                else
                {
                    string car = command;
                    queue.Enqueue(car);
                   
                }
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
