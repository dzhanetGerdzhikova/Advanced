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
        private Engine engine;
        private Tire[] tires;

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                this.tires = value;
            }
        }

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

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string _make, string _model, int _year) : this()
        {
            this.Make = _make;
            this.Model = _model;
            this.Year = _year;
        }

        public Car(string _make, string _model, int _year, double _fuelQuantity, double _fuelConsumption) : this(_make, _model, _year)
        {
            this.FuelQuantity = _fuelQuantity;
            this.FuelConsumption = _fuelConsumption;
        }

        public Car(string _make, string _model, int _year, double _fuelQuantity, double _fuelConsumption, Engine engine, Tire[] tires) : this(_make, _model, _year, _fuelQuantity, _fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
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
        }
    }
}