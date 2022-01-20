using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rack = int.Parse(Console.ReadLine());
            int numberOfRacks = 1;
            int currRack = rack;
            while (clothes.Count!=0)
            {
                if (currRack-clothes.Peek()>=0)
                {
                    currRack -= clothes.Pop();
                    if (currRack==0&&clothes.Count!=0)
                    {
                        numberOfRacks++;
                        currRack = rack;
                    }
                }
                else
                {
                    numberOfRacks++;
                    currRack = rack;
                }
            }
            Console.WriteLine(numberOfRacks);
        }
    }
}
