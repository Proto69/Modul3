using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings = new List<Topping>();
        private Dough dough;
        private double cal;


        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
        }

        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {CalculateCal(Dough, Toppings):F2} Calories.";
        }

        private static double CalculateCal(Dough dough, List<Topping> toppings)
        {
            double cal = 0;
            cal += dough.Cal;
            for (int i = 0; i < toppings.Count; i++)
            {
                cal += toppings[i].Cal;
            }
            return cal;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }
        internal List<Topping> Toppings
        {
            get => toppings;
            private set => toppings = value;
        }
        internal Dough Dough { get => dough; set => dough = value; }
    }
}
