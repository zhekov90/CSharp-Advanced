using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            var songs = new Queue<string>(input);
            while (songs.Any())
            {
                string command = Console.ReadLine();
                    
                if (command.StartsWith("Play"))
                {
                    songs.Dequeue();
                }
                else if (command.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
                else if (command.StartsWith("Add"))
                {
                    string songToAdd = command.Substring(4, command.Length-4);
                    if (!songs.Contains(songToAdd))
                    {
                        songs.Enqueue(songToAdd);
                    }
                    else
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
