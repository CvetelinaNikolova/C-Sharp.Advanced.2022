using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(names);
            while (queue.Count!=1)
            {
                for (int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
