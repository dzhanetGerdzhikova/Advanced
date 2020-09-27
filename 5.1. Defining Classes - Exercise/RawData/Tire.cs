namespace RawData
{
    public class Tire
    {
        private double tirePressure;
        private int tireAge;

        public Tire(double tirePressure, int tireAge)
        {
            this.TirePressure = tirePressure;
            this.tireAge = tireAge;
        }

        public double TirePressure
        {
            get { return tirePressure; }
            set { this.tirePressure = value; }
        }

        public int TireAge
        {
            get { return tireAge; }
            set { this.tireAge = value; }
        }
    }
}