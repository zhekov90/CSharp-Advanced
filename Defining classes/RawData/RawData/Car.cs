using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
   public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public List<Tire> tires;

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public override string ToString()
        {
            return model; 
        }
    }
}
