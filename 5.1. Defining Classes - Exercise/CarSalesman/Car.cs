using System;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        //        {CarModel
        //    }:
        //  {EngineModel
        //}:
        //    Power: {EnginePower}
        //    Displacement: {EngineDisplacement}
        //    Efficiency: {EngineEfficiency}
        //  Weight: {CarWeight}
        //  Color: {CarColor}

        public void PrintInfo()
        {
            Console.WriteLine($"{Model}:");
            Console.WriteLine($"\t{Engine.Model}:");
            Console.WriteLine($"\t\tPower: {Engine.Power}");
            string displacementText = Engine.Displacement == 0 ? "n/a" : Engine.Displacement.ToString();
            Console.WriteLine($"\t\tDisplacement: {displacementText}");
            string efficiencyText = Engine.Efficiency == null ? "n/a" : Engine.Efficiency;
            Console.WriteLine($"\t\tEfficiency: {efficiencyText}");
            string weightText = Weight == 0 ? "n/a" : Weight.ToString();
            Console.WriteLine($"\tWeight: {weightText}");
            string colorText = Color == null ? "n/a" : Color;
            Console.WriteLine($"\tColor: {colorText}");
        }
    }
}