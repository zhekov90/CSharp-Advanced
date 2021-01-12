using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);
                Engine engine = new Engine(model, power);

                if (input.Length==3)
                {
                    int displacement;
                    if (int.TryParse(input[2], out displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engines.Add(engine);
            }


            List<Car> cars = new List<Car>();

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engineModel = input[1];
                Engine engine = engines.FirstOrDefault(e => e.Model == engineModel);

                Car car = new Car(model, engine);

                if (input.Length==3)
                {
                    int weight;
                    if (int.TryParse(input[2], out weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                }
                else if (input.Length==4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    car.Weight = weight;
                    car.Color = color;
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
