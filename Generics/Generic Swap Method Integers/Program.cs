
using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            int n = int.Parse(Console.ReadLine());
            BoxStore<int> boxStore = new BoxStore<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                boxStore.AddBox(box);
               
            }

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            boxStore.SwapBoxes(indexes[0], indexes[1]);
            Console.WriteLine(boxStore);
        }
    }
}
