using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCars; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(currentCar);
            }

            string lineInfo = Console.ReadLine();

            while (lineInfo != "End")
            {
                string[] splitedInput = lineInfo.Split(' ').ToArray();
                string carModel = splitedInput[1];
                double amountOfKm = double.Parse(splitedInput[2]);

                Car car = cars.Where(e => e.Model == carModel).SingleOrDefault();
                if (car.CanDrive(amountOfKm))
                {
                    car.Drive(amountOfKm);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                lineInfo = Console.ReadLine();
            }
            cars.ForEach(x => x.PrintInfo());
        }
    }
}