using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Truck
    {
        private string name;
        private double maxWeight;
        private List<Freight> freights = new List<Freight>();

        public Truck(string name, double maxWeight)
        {
            this.Name = name;
            this.MaxWeight = maxWeight;
        }

        public void LoadTruck(Freight x)
        {
            if (x.Weight > maxWeight)
                throw new ArgumentException($"{Name} can not load {x.Name}");
            MaxWeight -= x.Weight;
            Console.WriteLine($"{Name} loaded {x.Name}");
            freights.Add(x);
        }

        public override string ToString()
        {
            if (freights.Count > 0)
                return $"{Name} - {string.Join(", ", freights)}";
            else return $"{Name} - Nothing loaded";
        }

        public double MaxWeight
        {
            get => maxWeight;
            set
            {
                Freight.CheckWeight(value);
                maxWeight = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                Freight.CheckName(value);
                name = value;
            }
        }
        internal List<Freight> Freights { get => freights; set => freights = value; }
    }
}
