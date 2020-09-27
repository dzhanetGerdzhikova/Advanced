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
    }
}