

namespace SpeedRacing
{
    public class Car
    {
        //private string model;
        //private double fuelAmount;
        //private double ffuelConsumptionPerKm;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TravelledDistance
        {
            get
            {
                return this.travelledDistance;
            }
        }

        public void Drive(double amountKm)
        {
            if (this.FuelConsumptionPerKm * amountKm > this.FuelAmount)
            {
                System.Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.FuelAmount -= this.FuelConsumptionPerKm * amountKm;
                this.travelledDistance += amountKm;
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
        }
    }
}
