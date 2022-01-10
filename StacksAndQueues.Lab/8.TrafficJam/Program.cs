using System;
using System.Collections.Generic;

namespace _8.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string command = Console.ReadLine();
            int carsPassed = 0;
            while (command.ToLower()!="end")
            {
                if (command.ToLower()=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count!=0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            carsPassed++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
