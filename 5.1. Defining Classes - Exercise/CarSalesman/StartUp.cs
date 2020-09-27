using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int countEngineLines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countEngineLines; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = inputInfo[0];
                int power = int.Parse(inputInfo[1]);

                Engine engine = new Engine(model, power);

                if (inputInfo.Length == 3)
                {
                    if (int.TryParse(inputInfo[2], out int displacement))
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = inputInfo[2];
                        engine.Efficiency = efficiency;
                    }
                }
                else if (inputInfo.Length == 4)
                {
                    int displacement = int.Parse(inputInfo[2]);
                    engine.Displacement = displacement;
                    string efficiency = inputInfo[3];
                    engine.Efficiency = efficiency;
                }

                engines.Add(engine);
            }

            int countCarLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCarLines; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string model = inputInfo[0];
                string engineModel = inputInfo[1];

                var searchEngine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

                Car car = new Car(model, searchEngine);

                if (inputInfo.Length == 3)
                {
                    if (int.TryParse(inputInfo[2], out int weight))
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = inputInfo[2];
                        car.Color = color;
                    }
                }
                else if (inputInfo.Length == 4)
                {
                    int weight = int.Parse(inputInfo[2]);
                    car.Weight = weight;
                    string color = inputInfo[3];
                    car.Color = color;
                }

                cars.Add(car);
            }
            cars.ForEach(c => c.PrintInfo());
        }
    }
}