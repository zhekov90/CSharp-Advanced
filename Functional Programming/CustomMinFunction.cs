using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> minFunc = FindMinNumber;

            int minNumber = minFunc(numbers);

            Console.WriteLine(minNumber);
        }

        private static int FindMinNumber(int[] numbers)
        {
            var min = int.MaxValue;

            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
