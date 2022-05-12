using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RaceTower
    {

        private int lap = 0;
        private int maxLaps;
        private int length;
        private Dictionary<string, Driver> dict = new Dictionary<string, Driver>();
        private string weatherType = "Sunny";

        //последният пример има една грешка

        public int MaxLaps { get => maxLaps; set => maxLaps = value; }
        public int Lap { get => lap; set => lap = value; }

        public void SetTrackInfo(int lapsNumber, int trackLength)
        {
            maxLaps = lapsNumber;
            length = trackLength;
        }
        public void RegisterDriver(List<string> input)
        {
            Driver driver;
            if (input[5] == "Ultrasoft")
            {
                Tyre tyre = new Tyre("Ultrasoft", double.Parse(input[6]), double.Parse(input[7]));
                Car car = new Car(int.Parse(input[3]), double.Parse(input[4]), tyre);
                driver = new Driver(input[1], input[2], car);
            }
            else
            {
                Tyre tyre = new Tyre(input[5], double.Parse(input[6]));
                Car car = new Car(int.Parse(input[3]), double.Parse(input[4]), tyre);
                driver = new Driver(input[1], input[2], car);
            }
            if (input[1] == "Aggressive") driver.FuelConsumptionPerKm = 2.7;
            else driver.FuelConsumptionPerKm = 1.5;
            dict.Add(input[2], driver);
        }

        public void DriverBoxes(List<string> input)
        {
            dict[input[2]].TotalTime += 20;
            if (input[1] == "Refuel")
            {
                dict[input[2]].Car.FuelAmount += double.Parse(input[3]);
            }
            else
            {
                if (input[3] == "Hard")
                {
                    dict[input[2]].Car.Tyre = new Tyre("Hard", double.Parse(input[4]));
                }
                else
                {
                    dict[input[2]].Car.Tyre = new Tyre("Ultrasoft", double.Parse(input[4]), double.Parse(input[5]));
                }
            }
        }

        public void CompleteLaps(List<string> input)
        {
            lap++;
            
            foreach (var pair in dict)
            {
                if (pair.Value.Fail == "No fail")
                {
                    Tyre tyre = pair.Value.Car.Tyre;
                    pair.Value.Speed = (pair.Value.Car.Hp + tyre.Degradtion) / pair.Value.Car.FuelAmount;
                    if (pair.Value.Type == "Aggressive") pair.Value.Speed *= 1.3;
                    pair.Value.TotalTime += 60 / (length / pair.Value.Speed);
                    pair.Value.Car.FuelAmount -= length * pair.Value.FuelConsumptionPerKm;
                    if (tyre.Name == "Hard")
                        tyre.Degradtion -= tyre.Hardness;
                    else tyre.Degradtion -= tyre.Hardness + tyre.Grip;
                    if (tyre.Degradtion <= 0 || tyre.Degradtion < 30 && tyre.Name == "Ultrasoft")
                    {
                        pair.Value.Fail = "Blown Tyre";
                    }
                    else if (pair.Value.Car.FuelAmount <= 0)
                    {
                        pair.Value.Fail = "Out of fuel!";
                    }
                }
            }
            bool check1 = false;
            bool check2 = false;
            List<Driver> list = new List<Driver>();
            foreach (var pair in dict)
            {
                if (pair.Value.Fail == "No fail")
                {
                    if (!check1) { list.Add(pair.Value); check1 = true; }
                    else if (!check2) { list.Add(pair.Value); check2 = true; }
                    else
                    {
                        CheckForOvertaking(list[0], list[1]);
                        check1 = false;
                        check2 = false;
                        list = new List<Driver>();
                    }
                }
            }
            if (lap == maxLaps)
            {
                Program.isRunning = false;
                Driver a = dict.OrderBy(x => x.Value.TotalTime).Where(x => x.Value.Fail == "No fail").First().Value;
                throw new ArgumentException($"{a.Name} wins the race for {a.TotalTime:F3} seconds.");
            }

        }

        public void GetLeaderboard()
        {
            Console.WriteLine($"Lap {lap}/{maxLaps}");
            int n = 0;
            foreach (var driver in dict.OrderBy(x => x.Value.TotalTime))
            {
                n++;
                if (driver.Value.Fail == "No fail")
                    Console.WriteLine($"{n}. {driver.Value.Name} {driver.Value.TotalTime:F3}");
            }
            n = 0;
            foreach (var driver in dict.OrderBy(x => x.Value.Name))
            {
                n++;
                if (driver.Value.Fail != "No fail")
                    Console.WriteLine($"{n}. {driver.Value.Name} {driver.Value.Fail}");
            }
        }

        public void ChangeWeather(List<string> input)
        {
            weatherType = input[1];
        }

        private void CheckForOvertaking(Driver driver2, Driver driver1)
        {
            
            if (driver2.Type == "Aggressive" && driver2.Car.Tyre.Name == "Ultrasoft" && driver2.TotalTime + 3 >= driver1.TotalTime)
            {
                if (weatherType == "Foggy")
                {
                    driver2.Fail = "Crashed";
                }
                else
                {
                    Console.WriteLine($"{driver2.Name} has overtaken {driver1.Name} on lap {lap}");
                    driver2.TotalTime -= 3;
                    driver1.TotalTime += 3;
                }
                
            }
            else if (driver2.Type == "Endurance" && driver2.Car.Tyre.Name == "Hard" && driver2.TotalTime + 3 >= driver1.TotalTime)
            {
                if (weatherType == "Rainy")
                {
                    driver2.Fail = "Crashed";
                }
                else
                {
                    Console.WriteLine($"{driver2.Name} has overtaken {driver1.Name} on lap {lap}");
                    driver2.TotalTime -= 3;
                    driver1.TotalTime += 3;
                }
            }
            else if (driver2.TotalTime + 2 >= driver1.TotalTime)
            {
                Console.WriteLine($"{driver2.Name} has overtaken {driver1.Name} on lap {lap}");
                driver2.TotalTime -= 2;
                driver1.TotalTime += 2;
            }
        }

    }
}
