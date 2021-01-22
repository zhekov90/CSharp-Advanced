using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Car car)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
           Car car = data.Where(x => x.Manufacturer == manufacturer).Where(c => c.Model == model).FirstOrDefault();
            if (car != null)
            {
                data.Remove(car);
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            Car car = data.OrderByDescending(c => c.Year).FirstOrDefault();
            if (car!=null)
            {
                return car;
            }
            else
            {
                return null;
            }
        }
         public Car GetCar(string manufacturer, string model)
        {
            Car car = data.Where(c => c.Manufacturer==manufacturer).Where(c=>c.Model==model).FirstOrDefault();
            if (car != null)
            {
                return car;
            }
            else
            {
                return null;
            }
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
