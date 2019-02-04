using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carModels = Console.ReadLine().Split();
            Queue<string> myQueue = new Queue<string>(carModels);
            Queue<string> servedCars = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    if (myQueue.Any())
                    {
                        Console.WriteLine($"Vehicles for service: {string.Join(", ", myQueue)}");
                    }
                    Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars.Reverse())}");
                    break;
                }
                if (command == "Service" && myQueue.Any())
                {
                    string carToPop = myQueue.Dequeue();
                    servedCars.Enqueue(carToPop);
                    Console.WriteLine($"Vehicle {carToPop} got served.");
                }
                else if (command.Contains("CarInfo"))
                {
                    string[] splittedCommand = command.Split("-");
                    string modelCar = splittedCommand[1];
                    if (!myQueue.Contains(modelCar)) // served
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (command == "History") // need to reverse servedCars
                {
                    Console.WriteLine($"{string.Join(", ", servedCars.Reverse())}");
                }
            }
        }
    }
}
