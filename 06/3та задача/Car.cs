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
        private Motor engine;
        private string weight;
        private string color;

        public Car()
        {

        }

        public Car(string model, Motor engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            return $"{Model}: \n  {Engine.Model}: \n   Power: {Engine.Power}" +
                $" \n   Displacement: {Engine.Displacement} \n   Efficiency: " +
                $"{Engine.Efficiency} \n  Weight: {Weight} \n  Color: {Color}";
        }

        public string Model { get => model; set => model = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        internal Motor Engine { get => engine; set => engine = value; }
    }
}
