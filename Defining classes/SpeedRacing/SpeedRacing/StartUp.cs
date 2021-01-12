﻿using System;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                decimal fuelAmmount = decimal.Parse(tokens[1]);
                decimal fuelCost = decimal.Parse(tokens[2]);
                cars[i] = new Car(model, fuelAmmount, fuelCost);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[1];
                decimal distance = decimal.Parse(tokens[2]);

                cars.Where(c => c.model == model).ToList().ForEach(c => c.Drive(distance));

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.model, car.fuelAmmount, car.distanceTravelled);
            }
        }
    }
}
