using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> listCars = new List<Car>();
            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split();
                string model = carsInfo[0];
                double fuelAmount = double.Parse(carsInfo[1]);
                double fuelConsumptionPerKm = double.Parse(carsInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                listCars.Add(car);
            }

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                string[] commandsArg = commands.Split();
                string model = commandsArg[1];
                double amountKilometers = double.Parse(commandsArg[2]);

                Car targetCar = listCars.Find(x => x.Model == model);

                if (targetCar != null)
                {
                    targetCar.Drive(amountKilometers);
                }
                commands = Console.ReadLine();
            }

            Console.WriteLine(String.Join(Environment.NewLine, listCars));
        }
    }
}
