using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int timeForGreenLine = int.Parse(Console.ReadLine());
            int timeForOpenWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> carsQueue = new Queue<string>();

            bool crash = false;
            string crashedCar = string.Empty;
            int hitIndex = -1;
            int countPassed = 0;

            while (input != "END")
            {
                if (input == "green")
                {
                    int timeAtMoment = timeForGreenLine;

                    while (carsQueue.Any() && timeAtMoment > 0)
                    {
                        string currentCar = carsQueue.Peek();
                        int timeForCurrentCar = currentCar.Length;
                        timeAtMoment -= timeForCurrentCar;

                        if (timeAtMoment >= 0)
                        {
                            carsQueue.Dequeue();
                            countPassed++;
                        }
                        else
                        {
                            int leftTime = Math.Abs(timeAtMoment);
                            if (leftTime <= timeForOpenWindow)
                            {
                                carsQueue.Dequeue();
                                countPassed++;
                            }
                            else
                            {
                                crash = true;
                                crashedCar = currentCar;
                                hitIndex = timeForCurrentCar - leftTime + timeForOpenWindow;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
                if (crash)
                {
                    break;
                }
                input = Console.ReadLine();
            }
            if (crash)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{crashedCar} was hit at {crashedCar[hitIndex]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{countPassed} total cars passed the crossroads.");
            }
        }
    }
}