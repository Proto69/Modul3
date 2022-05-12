using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Driver
    {
        private string name;
        private double totalTime;
        private string fail = "No fail";
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed;
        private string type;

        public Driver(string type, string name, Car car)
        {
            this.Name = name;
            this.Car = car;
            this.Type = type;
        }

        public string Name { get => name; set => name = value; }
        public double TotalTime { get => totalTime; set => totalTime = value; }
        public double FuelConsumptionPerKm { get => fuelConsumptionPerKm; set => fuelConsumptionPerKm = value; }
        public double Speed { get => speed; set => speed = value; }
        public string Type { get => type; set => type = value; }
        public string Fail { get => fail; set => fail = value; }
        internal Car Car { get => car; set => car = value; }
    }
}
