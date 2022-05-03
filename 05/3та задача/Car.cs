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
        private Motor motor = new Motor();
        private Package packages = new Package();
        private List<Tire> tires = new List<Tire>();

        public Car(string model, int motorSpeed, int MotorPower,
            int packMass, string packType, double tire1Preessure, int tire1Age,
            double tire2Preessure, int tire2Age, double tire3Preessure, int tire3Age,
            double tire4Preessure, int tire4Age)
        {
            this.model = model;
            motor.Speed = motorSpeed;
            motor.Power = MotorPower;
            packages.Mass = packMass;
            packages.Type = packType;
            tires.Add(new Tire(tire1Age, tire1Preessure));
            tires.Add(new Tire(tire2Age, tire2Preessure));
            tires.Add(new Tire(tire3Age, tire3Preessure));
            tires.Add(new Tire(tire4Age, tire4Preessure));
        }

        public string Model { get => model; set => model = value; }
        internal List<Tire> Tires { get => tires; set => tires = value; }
        internal Motor Motor { get => motor; set => motor = value; }
        internal Package Packages { get => packages; set => packages = value; }
    }
}
