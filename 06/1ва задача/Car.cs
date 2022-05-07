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
        private double fuel;
        private double fuelPerKm;
        private double km = 0;

        public Car (string model, double fuel, double fuelPerKm)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
        }

        public void Drive(double km)
        {
            if (fuelPerKm * km >= fuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                fuel -= FuelPerKm * km;
                this.km += km;
            }
        }

        public override string ToString()
        {
            return $"{model} {fuel:F2} {km}";
        }

        public string Model { get => model; set => model = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double FuelPerKm { get => fuelPerKm; set => fuelPerKm = value; }
        public double Km { get => km; set => km = value; }
    }
}
