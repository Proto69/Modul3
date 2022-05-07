using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        private string model;
        private double speed;

        public Car(string model, double speed)
        {
            Model = model;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"{Model} {Speed}";
        }

        public double Speed { get => speed; set => speed = value; }
        public string Model { get => model; set => model = value; }
    }
}
