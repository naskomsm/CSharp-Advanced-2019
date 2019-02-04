namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }

        public double Distance = 0;



        public Car(string model,double fuel,double consumption , double distance)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.Consumption = consumption;
            this.Distance = distance;
        }

    }
}
