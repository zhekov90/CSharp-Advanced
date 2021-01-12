using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();
            var command = Console.ReadLine();

            while (command != "No more tires")
            {
                var sep = command.Split().ToList();
                var newTire1 = new Tire(int.Parse(sep[0]), double.Parse(sep[1]));
                var newTire2 = new Tire(int.Parse(sep[2]), double.Parse(sep[3]));
                var newTire3 = new Tire(int.Parse(sep[4]), double.Parse(sep[5]));
                var newTire4 = new Tire(int.Parse(sep[6]), double.Parse(sep[7]));
                tires.Add(new Tire[] { newTire1, newTire2, newTire3, newTire4 });

                command = Console.ReadLine();
            }

            var engines = new List<Engine>();
            command = Console.ReadLine();
            while (command != "Engines done")
            {
                var sep = command.Split().ToList();
                var newEngine = new Engine(int.Parse(sep[0]), double.Parse(sep[1]));
                engines.Add(newEngine);
                command = Console.ReadLine();
            }

            var cars = new List<Car>();

            command = Console.ReadLine();

            while (command != "Show special")
            {
                var sep = command.Split().ToList();
                var make = sep[0];
                var model = sep[1];
                var year = int.Parse(sep[2]);
                var fuelQuantity = double.Parse(sep[3]);
                var fuelConsumption = double.Parse(sep[4]);
                var engine = engines[int.Parse(sep[5])];
                var tire = tires[int.Parse(sep[6])];
                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
                cars.Add(car);
                command = Console.ReadLine();
            }

            cars = cars
                 .Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            foreach (var item in cars)
            {
                item.Drive(20);
                Console.WriteLine(item.WhoAmI());
            }
        }
    }
}
