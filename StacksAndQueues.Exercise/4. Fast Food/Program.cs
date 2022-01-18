using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] Orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(Orders);
            int biggestOrder = int.MinValue;

            foreach (var item in orders)
            {
                if (item>biggestOrder)
                {
                    biggestOrder = item;
                }
            }
            while (orders.Count>0&&quantityOfFood>0)
            {
                if (quantityOfFood-orders.Peek()>=0)
                {
                    quantityOfFood -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(biggestOrder);
            if (orders.Count==0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
        }
    }
}
