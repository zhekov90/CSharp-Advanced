using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "Revision")
            {
                string name = input[0];
                string product = input[1];
                string price = input[2];

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new Dictionary<string, double>();
                    
                }
                if (!dict[name].ContainsKey(product))
                {
                    dict[name].Add(product, 0);
                }
                dict[name][product] = double.Parse(price);

                input = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
            }

            foreach (var store in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                   
                }
            }
        }
    }
}
