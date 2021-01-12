using Generic_Swap_Method_String;
using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            int n = int.Parse(Console.ReadLine());
            BoxStore<string> boxStore = new BoxStore<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                boxStore.AddBox(box);
               
            }

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            boxStore.SwapBoxes(indexes[0], indexes[1]);
            Console.WriteLine(boxStore);
        }
    }
}
