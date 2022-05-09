using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Topping
    {
        private string type;
        private double weight;
        private double cal;


        public Topping(string type, double weight)
        {
            Type = type;
            Weight = weight;

            switch (this.type)
            {
                case "meat":
                    cal = weight * 2 * 1.2;
                    break;
                case "veggies":
                    cal = weight * 2 * 0.8;
                    break;
                case "cheese":
                    cal = weight * 2 * 1.1;
                    break;
                case "sauce":
                    cal = weight * 2 * 0.9;
                    break;
            }
        }


        private string Type
        {
            set
            {
                string check = value.ToLower();
                if (check != "meat" && check != "veggies" && check != "check" && check != "sauce")
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                type = value.ToLower();
            }
        }

        private double Weight
        {
            set
            {
                if (value > 50 || value < 1)
                    throw new ArgumentException($"{type} weight should be in the range [1..50].");
                weight = value;
            }
        }


        public double Cal { get => cal; set => cal = value; }

    }
}
