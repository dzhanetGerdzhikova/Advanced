using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Engine engine = new Engine(560, 6300);
            //Tire[] tires = new Tire[4]
            //{
            //    new Tire(1,2.5),
            //    new Tire(1,2.1),
            //    new Tire(2,0.5),
            //    new Tire(2,2.3),
            //};
            //Car car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);

            string inputTires = Console.ReadLine();

            List<Tire[]> tiresList = new List<Tire[]>();
            while (inputTires != "No more tires")
            {
                double[] splitedInput = inputTires.Split(' ').Select(double.Parse).ToArray(); // 1 2.3 3 4.6  9 3.6 //List<tires>.to
                List<Tire> rowWithTires = new List<Tire>();

                for (int i = 0; i <= splitedInput.Length - 1; i += 2)
                {
                    var year = splitedInput[i];
                    var pressure = splitedInput[i + 1];

                    rowWithTires.Add(new Tire((int)year, pressure));
                }
                tiresList.Add(rowWithTires.ToArray());
                inputTires = Console.ReadLine();
            }

            List<Engine> engineList = new List<Engine>();

            string engineInput = Console.ReadLine();

            while (engineInput != "Engines done")
            {
                double[] splitedInput = engineInput.Split(' ').Select(double.Parse).ToArray();

                for (int i = 0; i <= splitedInput.Length - 1; i += 2)
                {
                    var horsePower = splitedInput[i];
                    var cubicCapacity = splitedInput[i + 1];

                    engineList.Add(new Engine((int)horsePower, cubicCapacity));
                }
                engineInput = Console.ReadLine();
            }

            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            while (input != "Show special")
            {
                string[] splitedInput = input.Split(' ');
                string make = splitedInput[0];
                string model = splitedInput[1];
                int year = int.Parse(splitedInput[2]);
                double fuelQuantity = double.Parse(splitedInput[3]);
                double fuelConsumption = double.Parse(splitedInput[4]);
                int engineIndex = int.Parse(splitedInput[5]);
                int tiresIndex = int.Parse(splitedInput[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tiresList[tiresIndex]);
                cars.Add(car);
                input = Console.ReadLine();
            }
            var specialCars = cars.Where(e => e.Year >= 2017 && e.Engine.HorsePower > 330 && e.Tires.Select(x => x.Pressure).Sum() > 9 && e.Tires.Select(x => x.Pressure).Sum() < 10);
            foreach (var specialCar in specialCars)
            {
                specialCar.Drive(20);
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}