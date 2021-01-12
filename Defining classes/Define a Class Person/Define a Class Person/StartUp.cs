using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(new Person(input[0],int.Parse(input[1])));
            }

            var result = people
             .Where(p => p.Age > 30)
             .OrderBy(p => p.Name);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
