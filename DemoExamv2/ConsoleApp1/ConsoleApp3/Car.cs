﻿namespace SoftUniParking
{
    using System.Text;

    public class Car
    {
        public Car(string make,string model,int horsepower,string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsepower;
            this.RegistrationNumber = registrationNumber;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }

        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"HorsePower: {this.HorsePower}");
            sb.Append($"RegistrationNumber: {this.RegistrationNumber}");
            return sb.ToString();
        }
    }
}
