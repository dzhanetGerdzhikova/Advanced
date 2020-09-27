using System;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value >= 0)
                {
                    fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set
            {
                if (value >= 0)
                {
                    fuelConsumption = value;
                }
            }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value >= 0)
                {
                    this.year = value;
                }
            }
        }

        public void Drive(double distance)
        {
            double neededQuantity = distance * fuelConsumption / 100;
            if (neededQuantity > fuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                fuelQuantity -= distance / 100 * fuelConsumption;
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:f2}L");

            return sb.ToString();

            //return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}