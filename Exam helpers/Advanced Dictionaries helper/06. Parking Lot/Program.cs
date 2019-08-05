using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carPlates = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] splittedInput = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string command = splittedInput[0].ToLower();
                string carPlate = splittedInput[1];

                if (command == "in")
                {
                    carPlates.Add(carPlate);
                }
                else if(command == "out")
                {
                    carPlates.Remove(carPlate);
                }
            }

            if (carPlates.Count > 0)
            {
                foreach (var carplatenumber in carPlates)
                {
                    Console.WriteLine(carplatenumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
