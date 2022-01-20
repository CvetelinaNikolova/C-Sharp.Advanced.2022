using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < N; i++)
            {
                int[] pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(pump);
            }


            bool complete = true;
            int pumpIndex=0;
            for (int i = 0; i < pumps.Count; i++)
            {
                complete = true;
                Queue<int[]> currPumps = new Queue<int[]>(pumps);

                for (int j = 0; j < i; j++)
                {
                    int[] pump = currPumps.Dequeue();
                    currPumps.Enqueue(pump);
                }

                int petrol = 0;

                for (int j = 0; j < currPumps.Count; j++)
                {
                    int[] pump = currPumps.Dequeue();
                    int petrolToPump = pump[0];
                    int distance = pump[1];
                    petrol += petrolToPump;
                    if (petrol-distance<0)
                    {
                        complete = false;
                        break;
                    }
                    else
                    {
                        petrol -=distance;
                    }
                }
                if (complete)
                {
                    pumpIndex = i;
                    break;
                }
            }

            Console.WriteLine(pumpIndex);
        }
    }
}
