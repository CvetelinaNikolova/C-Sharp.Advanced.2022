using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCost = int.Parse(Console.ReadLine());
            int barrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = int.Parse(Console.ReadLine());

            bool cracked = true;
            int currBarrel = barrel;
            while (bullets.Count!=0&&locks.Count!=0)
            {
                currBarrel--;
                    int bullet = bullets.Pop();
                value -= bulletCost;
                    int Lock = locks.Peek();
                if (Lock >= bullet)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if(locks.Count==0 || (bullets.Count == 0 && locks.Count == 0))
                {
                    cracked = true;
                }
                else if (bullets.Count==0)
                {
                    cracked = false;
                }

                if (currBarrel == 0&&bullets.Count!=0)
                {
                    currBarrel = barrel;
                    Console.WriteLine("Reloading!");
                }

            }

            if (cracked)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${value}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
