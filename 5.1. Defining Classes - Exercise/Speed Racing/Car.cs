using System;

namespace Speed_Racing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public bool CanDrive(double km)
        {
            double neededFuel = km * FuelConsumptionPerKilometer;
            return FuelAmount >= neededFuel;
        }

        public void Drive(double km)
        {
            double neededFuel = km * FuelConsumptionPerKilometer;
            FuelAmount -= neededFuel;
            TravelledDistance += km;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Model} {FuelAmount:f2} {TravelledDistance}");
        }
    }
}