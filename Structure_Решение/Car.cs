using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Car(int hp, double fuelAmount,Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;
        }

        public int Hp { get => hp; set => hp = value; }
        public double FuelAmount
        {
            get => fuelAmount;
            set
            {
                if (value > 160)
                    value = 160;
                fuelAmount = value;
            }
        }
    internal Tyre Tyre
        {
            get => tyre;
            set
            {
                tyre = value;
            }
        }
    }
}