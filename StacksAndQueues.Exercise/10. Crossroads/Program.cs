using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            int carsPassed = 0;

            Queue<string> cars = new Queue<string>();

            bool crashed = false;

            string command = Console.ReadLine();
            while (command.ToLower()!="end")
            {
                if (command.ToLower()=="green")
                {
                    int seconds = greenLight;
                    while (seconds>0)
                    {
                        string car = "";
                        if (cars.Count>0)
                        {
                            car = cars.Dequeue();
                        }
                        else
                        {
                            break;
                        }
                        if (seconds-car.Length<0)
                        {
                            int sec = car.Length - seconds;
                            seconds -= car.Length;
                            if (freeWindow-sec<0)
                            {
                                int index = car.Length-(sec - freeWindow);
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[index]}.");
                                crashed = true;
                                break;
                            }
                            carsPassed++;
                        }
                        else
                        {
                            seconds -= car.Length;
                            carsPassed++;
                        }
                    }
                    if (crashed)
                    {
                        break;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            if (!crashed)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
