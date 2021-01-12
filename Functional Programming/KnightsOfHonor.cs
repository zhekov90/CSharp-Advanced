using System;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> text = x => Console.WriteLine($"Sir {x}");

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(text);
        }
    }
}
