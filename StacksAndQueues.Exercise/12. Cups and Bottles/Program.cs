using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int waterWasted = 0;
            bool filled = true;

            while (cups.Count != 0 && bottles.Count != 0)
            {
                int cup = cups.Peek();
                while (cup>0&&bottles.Count!=0)
                {
                    int bottle = bottles.Pop();
                    if (cup-bottle<=0)
                    {
                        waterWasted += bottle - cup;
                        cup -= bottle;
                        cups.Dequeue();
                        break;
                    }
                    else
                    {
                        cup -= bottle;
                    }
                }


                if (bottles.Count==0&&cups.Count!=0)
                {
                    filled = false;
                }
            }

            if (filled)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {waterWasted}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {waterWasted}");
            }
        }
    }
}
