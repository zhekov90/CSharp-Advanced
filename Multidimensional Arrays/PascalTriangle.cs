using System;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());
            long currLength = 1;
            long[][] triangle = new long[rows][];

            for (long i = 0; i < rows; i++)
            {
                triangle[i] = new long[currLength];
                triangle[i][0] = 1;
                triangle[i][currLength-1] = 1;

                if (currLength>2)
                {
                    for (long j = 1; j < currLength-1; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j]; 
                    }
                }
                currLength++;
            }
            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
