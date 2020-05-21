using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();

            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int remainSecondsGreen = greenLight;
            int remainSecondsFreeWindow = freeWindow;

            int counterSafePassed = 0;
            bool hasCrash = false;

            while (input != "END")
            {

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else if (input == "green")
                {
                    while ( remainSecondsGreen != 0 && cars.Any())
                    {
                        string currentCar = cars.Peek();
                        int lenOfCar = currentCar.Length;

                        if (lenOfCar <= remainSecondsGreen)
                        {
                            remainSecondsGreen -= lenOfCar;
                            cars.Dequeue();
                            counterSafePassed++;
                        }
                        else
                        {
                            string enteredPartOfCar = currentCar.Substring(0, remainSecondsGreen);
                            string leftPartOfCar = currentCar.Substring(enteredPartOfCar.Length);
                            string letterOfCrash = String.Empty;

                            if (leftPartOfCar.Length <= remainSecondsFreeWindow)
                            {
                                cars.Dequeue();
                                counterSafePassed++;
                                remainSecondsGreen = 0;
                            }
                            else
                            {
                                letterOfCrash = leftPartOfCar[remainSecondsFreeWindow].ToString();
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {letterOfCrash}.");
                                hasCrash = true;
                                break;
                            }
                        }

                        if (!cars.Any())
                        {
                            break;
                        }
                    }

                    remainSecondsGreen = greenLight;
                    remainSecondsFreeWindow = freeWindow;

                    if (hasCrash)
                    {
                        break;
                    }
                    
                }

                input = Console.ReadLine();
            }

            if (!hasCrash)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counterSafePassed} total cars passed the crossroads.");
            }
        }
    }
}
