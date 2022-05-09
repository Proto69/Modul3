using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dough
    {
        private string type;
        private string wayOfMaking;
        private double weight;
        private double cal;

        public Dough(string type, string wayOfMaking, double weight)
        {
            Type = type;
            WayOfMaking = wayOfMaking;
            Weight = weight;

            switch (this.wayOfMaking)
            {
                case "crispy":
                    if (this.type == "white") cal = weight * 2 * 1.5 * 0.9;
                    else cal = weight * 2 * 0.9;
                    break;
                case "chewy":
                    if (this.type == "white") cal = weight * 2 * 1.5 * 1.1;
                    else cal = weight * 2 * 1.1;
                    break;
                case "homemade":
                    if (this.type == "white") cal = weight * 2 * 1.5;
                    else cal = weight * 2;
                    break;
            }

        }

        private string Type
        {
            set
            {
                value = value.ToLower();
                if (value != "white" && value != "wholegrain")
                    throw new ArgumentException("Invalid type of dough!");
                type = value;
            }
        }
        private string WayOfMaking
        {
            set
            {
                value = value.ToLower();
                if (value != "crispy" && value != "chewy" && value != "homemade")
                    throw new ArgumentException("Invalid type of dough!");
                wayOfMaking = value;
            }
        }
        private double Weight
        {
            set
            {
                if (value > 200 || value < 0)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                weight = value;
            }
        }

        public double Cal { get => cal; private set => cal = value; }
    }
}
