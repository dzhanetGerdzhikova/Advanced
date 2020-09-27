using System;/

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

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
                if (value <= 0)
                {
                    throw new InvalidOperationException();
                }

                this.year = value;
            }
        }
    }
}