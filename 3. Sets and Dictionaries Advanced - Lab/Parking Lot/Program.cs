using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> cars = new HashSet<string>();

            while (input != "END")
            {
                string[] splitedInput = input.Split(", ");
                string command = splitedInput[0];
                string numberOfCar = splitedInput[1];
                if (command == "IN")
                {
                    cars.Add(numberOfCar);
                }
                else if (command == "OUT")
                {
                    cars.Remove(numberOfCar);
                }

                input = Console.ReadLine();
            }
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}