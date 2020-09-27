using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countCar = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countCar; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(' ').ToArray();

                string model = inputInfo[0];

                int engineSpeed = int.Parse(inputInfo[1]);
                int enginePower = int.Parse(inputInfo[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(inputInfo[3]);
                string cargoType = inputInfo[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                List<Tire> tires = new List<Tire>();
                for (int indexInputInfo = 5; indexInputInfo < inputInfo.Length; indexInputInfo += 2)
                {
                    double tirePressure = double.Parse(inputInfo[indexInputInfo]);
                    int tireAge = int.Parse(inputInfo[indexInputInfo + 1]);
                    Tire tire = new Tire(tirePressure, tireAge);

                    tires.Add(tire);
                }
                Car currentCar = new Car(model, engine, cargo, tires.ToArray());
                cars.Add(currentCar);
            }

            string cargoTypeCommand = Console.ReadLine();

            if (cargoTypeCommand == "fragile")
            {
                //print all cars whose cargo is "fragile" with a tire, whose pressure is  < 1
                cars.Where(e => e.Cargo.CargoType == "fragile" && e.Tires.Any(x => x.TirePressure < 1)).ToList().ForEach(x => Console.WriteLine(x.Model));
            }
            else if (cargoTypeCommand == "flamable")
            {
                //print all of the cars, whose cargo is "flamable" and have engine power > 250
                cars.Where(e => e.Cargo.CargoType == "flamable" && e.Engine.EnginePower > 250).ToList().ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}