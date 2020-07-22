using System;
using System.Collections.Generic;
using System.Linq;

namespace Salesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            int numOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = null;
                
                if (engineInfo.Length == 2)
                {
                    engine = new Engine(model,power);
                }
                else if (engineInfo.Length == 3)
                {
                    int displacement;

                    bool isDisplacement = int.TryParse(engineInfo[2], out displacement );

                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model,power,engineInfo[2]);
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiecny = engineInfo[3];

                    engine = new Engine(model,power,displacement,efficiecny);
                }

                engineList.Add(engine);
            }

            int numCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCars; i++)
            {
                string[] carsInfo = Console.ReadLine().Split();
                string model = carsInfo[0];
                string engineModel = carsInfo[1];

                Car car = null;
                Engine engineToFind = engineList.Find(e => e.Model == engineModel);

                if (carsInfo.Length == 2)
                {
                    car = new Car(model,engineToFind);
                }
                else if (carsInfo.Length == 3)
                {
                    int weight;

                    bool isWeight = int.TryParse(carsInfo[2], out weight);

                    if (isWeight)
                    {
                        car = new Car(model, engineToFind,weight);
                    }
                    else
                    {
                        car = new Car(model,engineToFind,carsInfo[2]);
                    }
                }
                else if (carsInfo.Length == 4)
                {
                    int weight = int.Parse(carsInfo[2]);
                    string color = carsInfo[3];

                    car = new Car(model, engineToFind, weight, color);
                }

                carList.Add(car);
            }

            Console.WriteLine(String.Join(Environment.NewLine, carList));

            
        }
    }
}
