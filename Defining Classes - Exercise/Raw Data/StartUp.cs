using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> listCars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                string model = carInfo[0];

                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);

                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];

                double firstTirePressure = double.Parse(carInfo[5]);
                int firstTireAge = int.Parse(carInfo[6]);

                double secondTirePressure = double.Parse(carInfo[7]);
                int secondTireAge = int.Parse(carInfo[8]);

                double thirdTirePressure = double.Parse(carInfo[9]);
                int thirdTireAge = int.Parse(carInfo[10]);

                double fourthTirePressure = double.Parse(carInfo[11]);
                int fourthTireAge = int.Parse(carInfo[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                List<Tire> tires = new List<Tire>();
                tires.Add(new Tire(firstTirePressure, firstTireAge));
                tires.Add(new Tire(secondTirePressure, secondTireAge));
                tires.Add(new Tire(thirdTirePressure, thirdTireAge));
                tires.Add(new Tire(fourthTirePressure, fourthTireAge));

                Car car = new Car(model,engine,cargo,tires);

                listCars.Add(car);
            }

            string filter = Console.ReadLine();

            if (filter == "fragile")
            {
                var result = listCars.Where(x => x.Cargo.Type == filter && x.Tires.Any(t => t.Pressure < 1));
                Console.WriteLine(String.Join(Environment.NewLine,result));
            }
            else if (filter == "flamable")
            {
                var result = listCars.Where(x => x.Cargo.Type == filter && x.Engine.Power > 250);
                Console.WriteLine(String.Join(Environment.NewLine, result));
            }
        }
    }
}
