using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Car>> dict = new Dictionary<string, List<Car>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                //да, доста як конструктор
                Car car = new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4],
                    double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]),
                    double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]), int.Parse(input[12]));


                if (dict.ContainsKey(input[4]))
                {
                    dict[input[4]].Add(car);
                }
                else dict.Add(input[4], new List<Car>() { car });
            }
            string typeToShow = Console.ReadLine();
            foreach  ( Car car in dict[typeToShow])
            {
                //тук в условието пише с гуми с налягане по малко от 1, нз дали вс гуми трябва да са
                //с налягане по малко от, ако е така както си мисля, първият пример е грешен
                if (typeToShow == "fragile" && car.Tires.Where(x => x.Pressure < 1).ToList().Count == 4)
                {
                    Console.WriteLine(car.Model);
                }
                else if (typeToShow == "flamable" && car.Motor.Power > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}