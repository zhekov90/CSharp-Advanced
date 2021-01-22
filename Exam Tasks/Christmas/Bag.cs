using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
       private List<Present> data;

        public Bag(string color, int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            data = new List<Present>();
        }
        public string Color { get; set; }
        public int Capacity { get; set; }


        public void Add(Present present)
        {
            if (this.data.Count + 1 <= this.Capacity)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present present = this.data.FirstOrDefault(p => p.Name == name);
            if (present != null)
            {
                this.data.Remove(present);
                return true;
            }
            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present present = this.data.OrderByDescending(p => p.Weight).FirstOrDefault();
            return present;
        }

        public Present GetPresent(string name)
        {
            Present present = this.data.FirstOrDefault(p => p.Name == name);
            return present;
        }

        public int Count
        {
            get { return this.data.Count; }
            
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} bag contains:");
            foreach (var present in data)
            {
                sb.AppendLine(present.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
