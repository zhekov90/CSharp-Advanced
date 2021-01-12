using System;

namespace GenericScale
{
   public  class Program
    {
        static void Main(string[] args)
        {
            var intEqu = new EqualityScale<int>(5, 8);
            var intEqu2 = new EqualityScale<int>(6, 6);

            Console.WriteLine(intEqu.AreEqual());
            Console.WriteLine(intEqu2.AreEqual());
        }
    }
}
