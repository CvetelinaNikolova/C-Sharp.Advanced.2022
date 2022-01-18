using System;
using System.Linq;
using System.Collections.Generic;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberToPush = elements[0];
            int numberToPop = elements[1];
            int element = elements[2];
            int smallestNum = int.MaxValue;

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numberToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < numberToPop; i++)
            {
                stack.Pop();
            }

            foreach (var item in stack)
            {
                if (item<smallestNum)
                {
                    smallestNum = item;
                }
            }

            if (stack.Contains(element))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count>0&&!stack.Contains(element))
            {
                Console.WriteLine(smallestNum);
            }
            else if (stack.Count==0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
