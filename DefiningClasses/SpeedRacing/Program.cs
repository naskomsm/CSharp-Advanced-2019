namespace SpeedRacing
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Car> garage = new List<Car>();

            int cars = int.Parse(Console.ReadLine());
            for (int i = 0; i < cars; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string carModel = carInfo[0];
                double carFuel = double.Parse(carInfo[1]);
                double carConsumption = double.Parse(carInfo[2]);

                Car newCar = new Car(carModel, carFuel, carConsumption,0);
                garage.Add(newCar);

            }

            while (true)
            {
                string input = Console.ReadLine();
                if(input == "END")
                {
                    break;
                }

                string[] splittedInput = input.Split();
                
                string carModel = splittedInput[1];
                double drivenAmount = double.Parse(splittedInput[2]);

            }

        }
    }
}
